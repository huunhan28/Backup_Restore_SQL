using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BACKUP_RESTORE_SQL
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtDatabase.Text = "HUUNHAN";
            txtUser.Text = "sa";
            txtPass.Text = "123";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.servername = txtDatabase.Text;
            Program.loginname = txtUser.Text;
            Program.password = txtPass.Text;

            if (Program.KetNoi() != 0)
            {
                FormLogin.ActiveForm.Visible = false;
                FormMain main = new FormMain();
                main.Show();
            }
        }
    }
}
