using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ERP_System
{
    public class Tables_Operations
    {
        private static readonly string connectionString = "server=DESKTOP-8THKTFQ;Database=ERP_System;Integrated Security=True";

        public static DataTable LoadData(string tableName)
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

        public static void AddData(string tableName, List<string> data)
        {
            // string columns = string.Join(", ", data.Keys);
            // string values = string.Join(", ", data.Values);

            using SqlConnection connection = new SqlConnection(connectionString);
            string query = $"INSERT INTO {tableName} VALUES ({data})";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("تم إضافة البيانات بنجاح");
        }

        public static void UpdateData(string tableName, Dictionary<string, string> data, string condition)
        {
            string setValues = string.Join(", ", data.Select(kv => $"{kv.Key} = '{kv.Value}'"));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE {tableName} SET {setValues} WHERE {condition}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteData(string tableName, string condition)
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