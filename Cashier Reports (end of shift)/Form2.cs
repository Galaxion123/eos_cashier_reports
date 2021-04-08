using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cashier_Reports__end_of_shift_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string login_search(string Opera_login)
        {
            var Login = Path.Combine(Directory.GetCurrentDirectory(), "Login.xls");

            Excel.Application xlLog = new Excel.Application();
            xlLog.Visible = false;

            if (xlLog == null)
            {
                MessageBox.Show("Не удалось открыть Excel !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                Excel.Workbook xlLogworkbook = xlLog.Workbooks.Open(Login);

                Excel.Sheets xlLogsheets = xlLogworkbook.Worksheets;
                Excel.Worksheet xlLogins = (Excel.Worksheet)xlLogsheets.get_Item("Users");

                int i = 1;
                string value = (string)(xlLogins.Cells[i, "A"] as Excel.Range).Value;
                while (value != null)
                {
                    if (string.Compare(value, Opera_login) == 0)
                    {
                        xlLogworkbook.Close(false);
                        Properties.Settings.Default.i = i;
                        Console.WriteLine(i);
                        return Opera_login;
                    }
                    else
                    {
                        i++;
                        value = (string)(xlLogins.Cells[i, "A"] as Excel.Range).Value;
                    }
                }
                xlLogworkbook.Close(false);
                return null;
            }
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
            string Opera_login = textBox1.Text;
            if (login_search(Opera_login) != null)
            {
                Properties.Settings.Default.Cashier_Opera = textBox1.Text;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Неверный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
        }
    }
}
