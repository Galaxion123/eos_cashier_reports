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

        private void check_if_num(string str)
        {
            if (str.Trim().Length == 0)
                errorNumeric.SetError(Correct_textbox, "");
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    errorNumeric.SetError(Correct_textbox, "Номера чеков должны быть числами.");
                    break;
                }
                else
                {
                    errorNumeric.SetError(Correct_textbox, "");
                }
            }
        }

        private void check_refunds()
        {
            Double.TryParse(table12.Text, out double signal1);
            Double.TryParse(table22.Text, out double signal2);
            Double.TryParse(table32.Text, out double signal3);
            Double.TryParse(table42.Text, out double signal4);
            Double.TryParse(table52.Text, out double signal5);
            Double.TryParse(table62.Text, out double signal6);
            Double.TryParse(table72.Text, out double signal7);
            Double.TryParse(table82.Text, out double signal8);
            Double.TryParse(table92.Text, out double signal9);
            Double.TryParse(table102.Text, out double signal10);
            Double.TryParse(table112.Text, out double signal11);
            Double.TryParse(table122.Text, out double signal12);
            Double.TryParse(table132.Text, out double signal13);
            Double.TryParse(table142.Text, out double signal14);
            Double.TryParse(table152.Text, out double signal15);
            Double.TryParse(table162.Text, out double signal16);
            Double.TryParse(table172.Text, out double signal17);
            Double.TryParse(table182.Text, out double signal18);
            Double.TryParse(table192.Text, out double signal19);
            Double.TryParse(table202.Text, out double signal20);
            Double.TryParse(table212.Text, out double signal21);
            Double.TryParse(table222.Text, out double signal22);
            Double.TryParse(table232.Text, out double signal23);
            Double.TryParse(table242.Text, out double signal24);
            Double.TryParse(Refundsum.Text, out double comparator);

            double result = comparator - (signal1 + signal2 + signal3 + signal4 + signal5 + signal6 + signal7 + signal8 + signal9 + signal10 + signal11 + signal12 + signal13 + signal14 + signal15 + signal16 + signal17 + signal18 + signal19 + signal20 + signal21 + signal22 + signal23 + signal24);
            if (result != 0)
            {
                Correct_textbox.Text = "НЕТ";
                Correct_textbox.BackColor = Color.Red;
                Correct_result.Visible = true;
                Correct_result.Text = result.ToString();
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                Correct_textbox.Text = "ДА";
                Correct_textbox.BackColor = Color.Green;
                Correct_result.Visible = false;
                Correct_result.Text = result.ToString();
                button2.Enabled = true;
                button3.Enabled = true;
            }
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
            string str = Cashier_name.Text;
            if (str.Trim().Length == 0)
                errorName.SetError(Cashier_name, "Это поле не должно быть пустым. Укажите фамилию кассира.");
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(Cashier_name, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        break;
                    }
                    else
                        errorName.SetError(Cashier_name, "");
                }
            }
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
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(CCsum, "Это поле должно содержать число.");
                        break;
                    }
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
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(Cashsum, "Это поле должно содержать число.");
                        break;
                    }
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
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(Refundsum, "Это поле должно содержать число.");
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(Refundsum, "");
                    check_refunds();
                }
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
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(given_money_sum, "Это поле должно содержать число.");
                        break;
                    }
                }
                else
                    errorNumeric.SetError(given_money_sum, "");
            }
        }

        private void receptor_name_TextChanged(object sender, EventArgs e)
        {
            string str = receptor_name.Text;
            if (str.Trim().Length == 0)
                errorName.SetError(receptor_name, "Это поле не должно быть пустым. Укажите фамилию кассира.");
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(receptor_name, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        break;
                    }
                    else
                        errorName.SetError(receptor_name, "");
                }
            }
        }

        private void table11_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void Correct_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void table21_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table31_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table41_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table51_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table61_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table71_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table81_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table91_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table101_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table111_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table122_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table131_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table141_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table151_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table161_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table171_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table181_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table191_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table201_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table211_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table221_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table231_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table241_TextChanged(object sender, EventArgs e)
        {
            string str = table11.Text;
            check_if_num(str);
        }

        private void table22_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table12_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table52_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table42_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table32_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table62_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table72_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table82_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table92_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table102_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table112_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table121_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table132_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table142_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table152_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table162_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table172_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table182_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table192_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table202_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table212_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table222_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table232_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }

        private void table242_TextChanged(object sender, EventArgs e)
        {
            check_refunds();
        }
    }
}
