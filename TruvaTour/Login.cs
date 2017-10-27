using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruvaTour.Models;

namespace TruvaTour
{
    public partial class Login : Form
    {

        Customer _c;
        string _UserName;
        string _Password;

        public Login()
        {
            InitializeComponent();
        }

        public Login(Customer c) : this()
        {
            _c = c;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtbUserName.Text = "musteri";
            txtbPassword.Text = "1234";
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbUserName.Text) && !string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                _UserName = txtbUserName.Text;
                _Password = txtbPassword.Text;
                Customer customer = new Customer(_UserName, _Password);
                if (customer.TCNO == null)
                {
                    MessageBox.Show("yanlış giriş yaptınız!");                   
                }
                else
                {
                    Overview ovr = new Overview(customer);
                    this.Hide();
                    ovr.Show();
                }

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
