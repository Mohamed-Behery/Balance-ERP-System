namespace ERP_System
{
    partial class Manage_Vendors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnExportToExcel = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            comboSort = new ComboBox();
            comboFilter = new ComboBox();
            txtSearch = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tajawal", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(525, 0);
            dataGridView1.Margin = new Padding(5, 8, 5, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 659);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 18F, FontStyle.Bold);
            label1.Location = new Point(173, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 0;
            label1.Text = "إضافة مورد جديد";
            // 
            // txtName
            // 
            txtName.Font = new Font("Cairo", 16F);
            txtName.Location = new Point(78, 99);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "  الاسم";
            txtName.Size = new Size(372, 47);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Cairo", 16F);
            txtAddress.Location = new Point(78, 154);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "  العنوان";
            txtAddress.Size = new Size(372, 47);
            txtAddress.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Cairo", 16F);
            txtPhone.Location = new Point(78, 209);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "  رقم الهاتف";
            txtPhone.Size = new Size(372, 47);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Cairo", 16F);
            txtEmail.Location = new Point(78, 264);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  البريد الإلكتروني";
            txtEmail.Size = new Size(372, 47);
            txtEmail.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Cairo", 16F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(75, 22);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(372, 49);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "إضافة مورد";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Cairo", 16F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(264, 79);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 49);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.LightSeaGreen;
            btnExportToExcel.Cursor = Cursors.Hand;
            btnExportToExcel.Font = new Font("Cairo", 16F);
            btnExportToExcel.ForeColor = Color.White;
            btnExportToExcel.Location = new Point(264, 136);
            btnExportToExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(183, 49);
            btnExportToExcel.TabIndex = 8;
            btnExportToExcel.Text = "التصدير لإكسل";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Cairo", 16F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(75, 79);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 49);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Crimson;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Cairo", 16F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(75, 136);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 49);
            btnClose.TabIndex = 9;
            btnClose.Text = "إغلاق النموذج";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // comboSort
            // 
            comboSort.Cursor = Cursors.Hand;
            comboSort.Font = new Font("Cairo", 16F);
            comboSort.FormattingEnabled = true;
            comboSort.ItemHeight = 39;
            comboSort.Items.AddRange(new object[] { "الاسم", "العنوان" });
            comboSort.Location = new Point(264, 193);
            comboSort.Margin = new Padding(3, 4, 3, 4);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(183, 47);
            comboSort.TabIndex = 10;
            comboSort.Text = "  فرز حسب";
            comboSort.SelectedIndexChanged += comboSort_SelectedIndexChanged;
            // 
            // comboFilter
            // 
            comboFilter.Cursor = Cursors.Hand;
            comboFilter.Font = new Font("Cairo", 16F);
            comboFilter.FormattingEnabled = true;
            comboFilter.ItemHeight = 39;
            comboFilter.Items.AddRange(new object[] { "الاسم", "العنوان" });
            comboFilter.Location = new Point(75, 193);
            comboFilter.Margin = new Padding(3, 4, 3, 4);
            comboFilter.Name = "comboFilter";
            comboFilter.Size = new Size(183, 47);
            comboFilter.TabIndex = 11;
            comboFilter.Text = "  فلترة";
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Cairo", 16F);
            txtSearch.Location = new Point(75, 248);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  بحث بالاسم";
            txtSearch.Size = new Size(372, 47);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(comboFilter);
            panel1.Controls.Add(comboSort);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnExportToExcel);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 331);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 327);
            panel1.TabIndex = 10;
            // 
            // Manage_Vendors
            // 
            AutoScaleDimensions = new SizeF(11F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 659);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 16F);
            Margin = new Padding(5, 8, 5, 8);
            MaximizeBox = false;
            Name = "Manage_Vendors";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة الموردين";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnExportToExcel;
        private Button btnDelete;
        private Button btnClose;
        private ComboBox comboSort;
        private ComboBox comboFilter;
        private TextBox txtSearch;
        private Panel panel1;
    }
}