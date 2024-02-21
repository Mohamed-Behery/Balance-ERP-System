using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void إدارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Vendors manage_Vendors = new Manage_Vendors();
            manage_Vendors.Show();
        }

        private void إغلاقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد الإغلاق", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (close == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void أخذنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerConnection connection = new ServerConnection("DESKTOP-8THKTFQ");
            Server server = new Server(connection);
            Database database = server.Databases["ERP_System"];

            Backup backup = new Backup
            {
                Action = BackupActionType.Database,
                Database = database.Name,
                Initialize = true,
                Checksum = true,
                ContinueAfterError = true,
                Incremental = false,
                LogTruncation = BackupTruncateLogType.Truncate,
                FormatMedia = false
            };

            BackupDeviceItem backupDevice = new BackupDeviceItem(@"M:\New folder\BackupFile.bak", DeviceType.File);
            backup.Devices.Add(backupDevice);
            backup.SqlBackup(server);
            MessageBox.Show("تم عمل النسخة الإحتياطية بنجاح");
        }
    }
}
