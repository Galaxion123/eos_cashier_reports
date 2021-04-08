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
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
        }

        private string new_user_creation(string opera_login)
        {
            return null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (str.Trim().Length == 0)
            {
                errorName.SetError(textBox2, "Это поле не должно быть пустым. Укажите фамилию кассира.");
                button1.Enabled = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(textBox2, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        button1.Enabled = false;
                        break;
                    }
                    else
                    {
                        errorName.SetError(textBox2, "");
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str = textBox3.Text;

            if (str.Trim().Length == 0)
            {
                errorName.SetError(textBox3, "Это поле не должно быть пустым.");
                button1.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    errorName.SetError(textBox3, "Это поле должно содержать число.");
                    button1.Enabled = false;
                    break;
                }
                else
                {
                    errorName.SetError(textBox3, "");
                    button1.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите логин из Оперы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите Фамилию И. О.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (comboBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else
            {
                var Login = Path.Combine(Directory.GetCurrentDirectory(), "Login.xls");

                Excel.Application xlLog = new Excel.Application();
                xlLog.Visible = false;

                if (xlLog == null)
                {
                    MessageBox.Show("Не удалось открыть Excel !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                        i++;
                        value = (string)(xlLogins.Cells[i, "A"] as Excel.Range).Value;
                    }
                    xlLogins.Cells[i, "A"] = textBox1.Text;
                    xlLogins.Cells[i, "B"] = textBox2.Text;
                    xlLogins.Cells[i, "C"] = textBox3.Text;
                    xlLogins.Cells[i, "D"] = comboBox1.Text;

                    Properties.Settings.Default.Cashier_Opera = textBox1.Text;
                    Properties.Settings.Default.Cashier_name = textBox2.Text;
                    Properties.Settings.Default.Cashier_number = textBox3.Text;
                    Properties.Settings.Default.Cashier = comboBox1.Text;

                    Properties.Settings.Default.Save();

                    xlLogworkbook.Close(true);
                    DialogResult = DialogResult.OK;
                }
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Trim().Length == 0)
            {
                errorName.SetError(textBox1, "Это поле не должно быть пустым.");
                button1.Enabled = false;
            }
        }
    }
}
