using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cashier_Reports__end_of_shift_
{
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
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
            DialogResult = DialogResult.OK;
        }
    }
}
