using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cashier_Reports__end_of_shift_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string login_search(string login)
        {
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            if (login_search(login) != null)
            {
                Properties.Settings.Default.Cashier_Opera = textBox1.Text;
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Неверный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
