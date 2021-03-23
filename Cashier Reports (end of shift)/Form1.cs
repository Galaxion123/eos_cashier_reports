using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Reports__end_of_shift_
{
    public partial class EOSReports : Form
    {
        public EOSReports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Refunds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashier_name_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string str = Cashier_name.Text;
            if (str.Trim().Length == 0)
                errorName.SetError(Cashier_name, "Это поле не должно быть пустым. Укажите фамилию кассира.");
            else
                errorName.SetError(Cashier_name, "");
        }

        private void CCsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = CCsum.Text;
            if (str.Trim().Length == 0)
                errorNumeric.SetError(CCsum, "Это поле не должно быть пустым.");
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                    errorNumeric.SetError(CCsum, "Это поле должно содержать число.");
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == '.' || str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                        errorNumeric.SetError(CCsum, "Это поле должно содержать число.");
                }
                else
                    errorNumeric.SetError(CCsum, "");
            }
        }

        private void Cashsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = Cashsum.Text;
            if (str.Trim().Length == 0)
                errorNumeric.SetError(Cashsum, "Это поле не должно быть пустым.");
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                    errorNumeric.SetError(Cashsum, "Это поле должно содержать число.");
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == '.' || str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                        errorNumeric.SetError(Cashsum, "Это поле должно содержать число.");
                }
                else
                    errorNumeric.SetError(Cashsum, "");
            }
        }

        private void Refundsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = Refundsum.Text;
            if (str.Trim().Length == 0)
                errorNumeric.SetError(Refundsum, "Это поле не должно быть пустым.");
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                    errorNumeric.SetError(Refundsum, "Это поле должно содержать число.");
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == '.' || str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                        errorNumeric.SetError(Refundsum, "Это поле должно содержать число.");
                }
                else
                    errorNumeric.SetError(Refundsum, "");
            }
        }

        private void given_money_sum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = given_money_sum.Text;
            if (str.Trim().Length == 0)
                errorNumeric.SetError(given_money_sum, "Это поле не должно быть пустым.");
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                    errorNumeric.SetError(given_money_sum, "Это поле должно содержать число.");
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == '.' || str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                        errorNumeric.SetError(given_money_sum, "Это поле должно содержать число.");
                }
                else
                    errorNumeric.SetError(given_money_sum, "");
            }
        }
    }
}
