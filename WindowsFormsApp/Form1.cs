using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbUsername.Text, tbPassword.Text);
            if (employee.Login(employee.LoginName, employee.Password))
            {
                MessageBox.Show("Login berhasil, ID anda adalah " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login gagal!");
            }
        }
    }
}
