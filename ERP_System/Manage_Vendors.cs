using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ERP_System
{
    public partial class Manage_Vendors : Form
    {
        private static readonly string connectionString = "server=DESKTOP-8THKTFQ;Database=ERP_System;Integrated Security=True";

        public Manage_Vendors()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;

            dataGridView1.DataSource = LoadData("Vendors");
            // Set column headers
            // dataGridView1.Columns[0].HeaderText = "رقم المورد";
            // dataGridView1.Columns[1].HeaderText = "الاسم";
            // dataGridView1.Columns[2].HeaderText = "العنوان";
            // dataGridView1.Columns[3].HeaderText = "الهاتف";
            // dataGridView1.Columns[4].HeaderText = "البريد";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;

            label1.Text = "تعديل بيانات المورد";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                List<string> data = new List<string>
                {
                    txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text
                };

                AddData("Vendors", data);

                dataGridView1.DataSource = LoadData("Vendors");
            }
            else
            {
                MessageBox.Show("قم بإدخال اسم المورد على الأقل");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                int vendorID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                List<string> data = new List<string>
        {
            txtName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text
        };

                UpdateData("Vendors", data, $"Vendor_ID = {vendorID}");

                dataGridView1.DataSource = LoadData("Vendors");

                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                ClearFields();
                label1.Text = "إضافة مورد جديد";
            }
            else
            {
                MessageBox.Show("قم بإدخال اسم المورد على الأقل");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData("Vendors", "Vendor_ID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("ببيانات الجدول");

                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGridView1.Columns[i - 1].HeaderText;
                    }




                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1].Value = "";
                            }
                        }
                    }



                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.Title = "حفظ الملف ك";
                    saveFileDialog.FileName = "بيانات الجدول";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        package.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("تم حفظ الملف بنجاح", "التصدير لإكسل");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تصدير البيانات: " + ex.Message);
            }
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSort.SelectedItem.ToString() == "الاسم")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.Sort = "Name";
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.Sort = "Address";
            }
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM Vendors where Name like '%" + txtSearch.Text + "%'";
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable LoadData(string tableName)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public void AddData(string tableName, List<string> data)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = $"INSERT INTO {tableName} VALUES ({string.Join(", ", data.Select(s => $"'{s}'"))})";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("تم إضافة البيانات بنجاح");
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        public void UpdateData(string tableName, List<string> data, string condition)
        {
            string setValues = string.Join(", ", data.Select((value, index) => $"{dataGridView1.Columns[index + 1].HeaderText} = '{value}'"));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE {tableName} SET {setValues} WHERE {condition}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("تم تحديث البيانات بنجاح");
            }
        }

        public void DeleteData(string tableName, string condition)
        {
            DialogResult decision = MessageBox.Show("هل تريد حذف الصف المحدد؟", "تأكيد الحذف", MessageBoxButtons.OKCancel);
            if (decision == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"DELETE FROM {tableName} WHERE {condition}";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("تم حذف البيانات بنجاح");
                }
            }
        }
    }
}
