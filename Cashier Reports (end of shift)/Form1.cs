using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Cashier_Reports__end_of_shift_
{
    public partial class EOSReports : Form
    {
        public EOSReports()
        {
            //Icon by FatCow Web Hosting
            InitializeComponent();
            check_refunds();
        }

        private void check_if_num(string str)
        {
            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(Correct_textbox, "");
                button2.Enabled = true;
                button3.Enabled = true;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    errorNumeric.SetError(Correct_textbox, "Номера чеков должны быть числами.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    break;
                }
                else
                {
                    errorNumeric.SetError(Correct_textbox, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        private void check_refunds()
        {
            Double.TryParse(textBox1.Text, out double CC);
            Double.TryParse(textBox2.Text, out double Cash);

            double Ref = CC + Cash;
            Refundsum.Text = Ref.ToString();

            Double.TryParse(table22.Text, out double signal1);
            Double.TryParse(table12.Text, out double signal2);
            Double.TryParse(table52.Text, out double signal3);
            Double.TryParse(table42.Text, out double signal4);
            Double.TryParse(table32.Text, out double signal5);
            Double.TryParse(table62.Text, out double signal6);
            Double.TryParse(table72.Text, out double signal7);
            Double.TryParse(table82.Text, out double signal8);
            Double.TryParse(table92.Text, out double signal9);
            Double.TryParse(table102.Text, out double signal10);
            Double.TryParse(table112.Text, out double signal11);
            Double.TryParse(table121.Text, out double signal12);
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
            if (comboBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else
            {
                var Reports = Path.Combine(Directory.GetCurrentDirectory(), "Reports.xls");
                var SumString = Path.Combine(Directory.GetCurrentDirectory(), "SumString.xla");
                string CC = "Кредитные карты";
                string cash = "Инкассация";
                string refund = "Возврат";
                string Act1 = "Акт Возврат";
                string Act2 = "Акт Возврат (2 лист)";
                string Act3 = "Акт Возврат (3 лист)";
                string Pri = "Приходник";

                Excel.Application xlRep = new Excel.Application();
                xlRep.Visible = false;

                if (xlRep == null)
                {
                    MessageBox.Show("Не удалось открыть Excel !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Excel.Workbook xlRepworkbook = xlRep.Workbooks.Open(Reports);
                    xlRep.Workbooks.Open(SumString);

                    Excel.Sheets xlRepsheets = xlRepworkbook.Worksheets;
                    Excel.Worksheet xlCC = (Excel.Worksheet)xlRepsheets.get_Item(CC);
                    Excel.Worksheet xlcash = (Excel.Worksheet)xlRepsheets.get_Item(cash);
                    Excel.Worksheet xlCrefund = (Excel.Worksheet)xlRepsheets.get_Item(refund);
                    Excel.Worksheet xlAct1 = (Excel.Worksheet)xlRepsheets.get_Item(Act1);
                    Excel.Worksheet xlAct2 = (Excel.Worksheet)xlRepsheets.get_Item(Act2);
                    Excel.Worksheet xlAct3 = (Excel.Worksheet)xlRepsheets.get_Item(Act3);
                    Excel.Worksheet xlPri = (Excel.Worksheet)xlRepsheets.get_Item(Pri);

                    Double.TryParse(CCsum.Text, out double creditcards);

                    if (creditcards != 0)
                    {
                        xlCC.Cells[8, "BA"] = comboBox1.Text;
                        xlCC.Cells[20, "E"] = textBox3.Text;
                        xlCC.Cells[20, "AO"] = CCsum.Text;
                        xlCC.Cells[54, "Y"] = Cashier_name.Text;
                        xlCC.PrintOutEx();
                    }

                    Double.TryParse(Cashsum.Text, out double cashsum);

                    if (cashsum != 0)
                    {
                        xlcash.Cells[8, "BA"] = comboBox1.Text;
                        xlcash.Cells[20, "E"] = textBox3.Text;
                        xlcash.Cells[20, "AO"] = Cashsum.Text;
                        xlcash.Cells[54, "Y"] = Cashier_name.Text;
                        xlcash.PrintOutEx();
                    }

                    Double.TryParse(Refundsum.Text, out double Refsum);

                    if (Refsum != 0)
                    {
                        xlCrefund.Cells[8, "BA"] = comboBox1.Text;
                        xlCrefund.Cells[20, "E"] = textBox3.Text;
                        xlCrefund.Cells[20, "AO"] = Refundsum.Text;
                        xlCrefund.Cells[54, "Y"] = Cashier_name.Text;
                        xlCrefund.PrintOutEx();

                        xlAct1.Cells[10, "X"] = comboBox1.Text;
                        xlAct1.Cells[13, "X"] = Cashier_name.Text;
                        xlAct1.Cells[55, "P"] = Cashier_name.Text;
                        xlAct1.Cells[38, "Q"] = Refundsum.Text;
                        for (int c = 30; c <= 37; c++)
                        {
                            xlAct1.Cells[c, "L"] = "";
                            xlAct1.Cells[c, "Q"] = "";
                        }

                        xlAct2.Cells[10, "X"] = comboBox1.Text;
                        xlAct2.Cells[13, "X"] = Cashier_name.Text;
                        xlAct2.Cells[55, "P"] = Cashier_name.Text;
                        xlAct2.Cells[38, "Q"] = Refundsum.Text;
                        for (int c = 30; c <= 37; c++)
                        {
                            xlAct2.Cells[c, "L"] = "";
                            xlAct2.Cells[c, "Q"] = "";
                        }

                        xlAct3.Cells[10, "X"] = comboBox1.Text;
                        xlAct3.Cells[13, "X"] = Cashier_name.Text;
                        xlAct3.Cells[55, "P"] = Cashier_name.Text;
                        xlAct3.Cells[38, "Q"] = Refundsum.Text;
                        for (int c = 30; c <= 37; c++)
                        {
                            xlAct3.Cells[c, "L"] = "";
                            xlAct3.Cells[c, "Q"] = "";
                        }

                        string[] num = new string[] { table11.Text, table21.Text, table31.Text, table41.Text, table51.Text, table61.Text, table71.Text, table81.Text, table91.Text, table101.Text, table111.Text, table121.Text, table131.Text, table141.Text, table151.Text, table161.Text, table171.Text, table181.Text, table191.Text, table201.Text, table211.Text, table221.Text, table231.Text, table241.Text };
                        string[] Ref = new string[] { table12.Text, table22.Text, table32.Text, table42.Text, table52.Text, table62.Text, table72.Text, table82.Text, table92.Text, table102.Text, table112.Text, table122.Text, table132.Text, table142.Text, table152.Text, table162.Text, table172.Text, table182.Text, table192.Text, table202.Text, table212.Text, table222.Text, table232.Text, table242.Text };

                        int j = 30;
                        int count = 1;

                        for (int i = 0; num[i].Length != 0; i++)
                        {
                            if (count <= 8)
                            {
                                xlAct1.Cells[j, "L"] = num[i];
                                xlAct1.Cells[j, "Q"] = Ref[i];
                                j++;
                                count++;
                            }
                            else if (count == 9)
                            {
                                j = 30;
                                xlAct2.Cells[j, "L"] = num[i];
                                xlAct2.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                            else if (count > 9 && count <= 16)
                            {
                                xlAct2.Cells[j, "L"] = num[i];
                                xlAct2.Cells[j, "Q"] = Ref[i];
                                j++;
                                count++;
                            }
                            else if (count == 17)
                            {
                                j = 30;
                                xlAct3.Cells[j, "L"] = num[i];
                                xlAct3.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                            else if (count > 17 && count <= 24)
                            {
                                xlAct3.Cells[j, "L"] = num[i];
                                xlAct3.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                        }
                        if (count >= 1)
                        {
                            xlAct1.PrintOutEx();
                        }
                        if (count >= 9)
                        {
                            xlAct2.PrintOutEx();
                        }
                        if (count >= 17)
                        {
                            xlAct3.PrintOutEx();
                        }
                    }

                    Double.TryParse(given_money_sum.Text, out double given);

                    if (given != 0)
                    {
                        xlPri.Cells[9, "AZ"] = comboBox1.Text;
                        xlPri.Cells[21, "L"] = textBox3.Text;
                        xlPri.Cells[21, "AM"] = given_money_sum.Text;
                        xlPri.Cells[23, "I"] = Cashier_name.Text;
                        xlPri.Cells[36, "Z"] = receptor_name.Text;
                        xlPri.PrintOutEx();
                    }

                    xlRepworkbook.Close(false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите номер кассира", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else
            {
                var Reports = Path.Combine(Directory.GetCurrentDirectory(), "Reports.xls");
                var SumString = Path.Combine(Directory.GetCurrentDirectory(), "SumString.xla");
                string CC = "Кредитные карты";
                string cash = "Инкассация";
                string refund = "Возврат";
                string Act1 = "Акт Возврат";
                string Act2 = "Акт Возврат (2 лист)";
                string Act3 = "Акт Возврат (3 лист)";
                string Pri = "Приходник";

                Excel.Application xlRep = new Excel.Application();
                xlRep.Visible = true;

                if (xlRep == null)
                {
                    MessageBox.Show("Не удалось открыть Excel !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Excel.Workbook xlRepworkbook = xlRep.Workbooks.Open(Reports);
                    xlRep.Workbooks.Open(SumString);

                    Excel.Sheets xlRepsheets = xlRepworkbook.Worksheets;
                    Excel.Worksheet xlCC = (Excel.Worksheet)xlRepsheets.get_Item(CC);
                    Excel.Worksheet xlcash = (Excel.Worksheet)xlRepsheets.get_Item(cash);
                    Excel.Worksheet xlCrefund = (Excel.Worksheet)xlRepsheets.get_Item(refund);
                    Excel.Worksheet xlAct1 = (Excel.Worksheet)xlRepsheets.get_Item(Act1);
                    Excel.Worksheet xlAct2 = (Excel.Worksheet)xlRepsheets.get_Item(Act2);
                    Excel.Worksheet xlAct3 = (Excel.Worksheet)xlRepsheets.get_Item(Act3);
                    Excel.Worksheet xlPri = (Excel.Worksheet)xlRepsheets.get_Item(Pri);

                    xlCC.Cells[8, "BA"] = comboBox1.Text;
                    xlCC.Cells[20, "E"] = textBox3.Text;
                    xlCC.Cells[20, "AO"] = CCsum.Text;
                    xlCC.Cells[54, "Y"] = Cashier_name.Text;

                    xlcash.Cells[8, "BA"] = comboBox1.Text;
                    xlcash.Cells[20, "E"] = textBox3.Text;
                    xlcash.Cells[20, "AO"] = Cashsum.Text;
                    xlcash.Cells[54, "Y"] = Cashier_name.Text;

                    Double.TryParse(Refundsum.Text, out double Refsum);

                    if (Refsum != 0)
                    {
                        xlCrefund.Cells[8, "BA"] = comboBox1.Text;
                        xlCrefund.Cells[20, "E"] = textBox3.Text;
                        xlCrefund.Cells[20, "AO"] = Refundsum.Text;
                        xlCrefund.Cells[54, "Y"] = Cashier_name.Text;

                        xlAct1.Cells[10, "X"] = comboBox1.Text;
                        xlAct1.Cells[13, "X"] = Cashier_name.Text;
                        xlAct1.Cells[55, "P"] = Cashier_name.Text;
                        xlAct1.Cells[38, "Q"] = Refundsum.Text;
                        for (int c = 30; c <= 37; c++)
                        {
                            xlAct1.Cells[c, "L"] = "";
                            xlAct1.Cells[c, "Q"] = "";
                        }

                        xlAct2.Cells[10, "X"] = comboBox1.Text;
                        xlAct2.Cells[13, "X"] = Cashier_name.Text;
                        xlAct2.Cells[55, "P"] = Cashier_name.Text;
                        xlAct2.Cells[38, "Q"] = Refundsum.Text;
                        for ( int c = 30; c <= 37; c++)
                        {
                            xlAct2.Cells[c, "L"] = "";
                            xlAct1.Cells[c, "Q"] = "";
                        }

                        xlAct3.Cells[10, "X"] = comboBox1.Text;
                        xlAct3.Cells[13, "X"] = Cashier_name.Text;
                        xlAct3.Cells[55, "P"] = Cashier_name.Text;
                        xlAct3.Cells[38, "Q"] = Refundsum.Text;
                        for (int c = 30; c <= 37; c++)
                        {
                            xlAct3.Cells[c, "L"] = "";
                            xlAct1.Cells[c, "Q"] = "";
                        }

                        string[] num = new string[] { table11.Text, table21.Text, table31.Text, table41.Text, table51.Text, table61.Text, table71.Text, table81.Text, table91.Text, table101.Text, table111.Text, table121.Text, table131.Text, table141.Text, table151.Text, table161.Text, table171.Text, table181.Text, table191.Text, table201.Text, table211.Text, table221.Text, table231.Text, table241.Text };
                        string[] Ref = new string[] { table12.Text, table22.Text, table32.Text, table42.Text, table52.Text, table62.Text, table72.Text, table82.Text, table92.Text, table102.Text, table112.Text, table122.Text, table132.Text, table142.Text, table152.Text, table162.Text, table172.Text, table182.Text, table192.Text, table202.Text, table212.Text, table222.Text, table232.Text, table242.Text };

                        int j = 30;
                        int count = 1;

                        for (int i = 0; num[i].Length != 0; i++)
                        {
                            if (count <= 8)
                            {
                                xlAct1.Cells[j, "L"] = num[i];
                                xlAct1.Cells[j, "Q"] = Ref[i];
                                j++;
                                count++;
                            }
                            else if (count == 9)
                            {
                                j = 30;
                                xlAct2.Cells[j, "L"] = num[i];
                                xlAct2.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                            else if (count > 9 && count <= 16)
                            {
                                xlAct2.Cells[j, "L"] = num[i];
                                xlAct2.Cells[j, "Q"] = Ref[i];
                                j++;
                                count++;
                            }
                            else if (count == 17)
                            {
                                j = 30;
                                xlAct3.Cells[j, "L"] = num[i];
                                xlAct3.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                            else if (count > 17 && count <= 24)
                            {
                                xlAct3.Cells[j, "L"] = num[i];
                                xlAct3.Cells[j, "Q"] = Ref[i];
                                count++;
                                j++;
                            }
                        }
                    }

                    Double.TryParse(given_money_sum.Text, out double given);

                    if (given != 0)
                    {
                        xlPri.Cells[9, "AZ"] = comboBox1.Text;
                        xlPri.Cells[21, "L"] = textBox3.Text;
                        xlPri.Cells[21, "AM"] = given_money_sum.Text;
                        xlPri.Cells[23, "I"] = Cashier_name.Text;
                        xlPri.Cells[36, "Z"] = receptor_name.Text;
                    }

                    xlCC.Activate();
                }
            }    
        }

        private void Refunds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashier_name_TextChanged(object sender, EventArgs e)
        {
            string str = Cashier_name.Text;
            if (str.Trim().Length == 0)
            {
                errorName.SetError(Cashier_name, "Это поле не должно быть пустым. Укажите фамилию кассира.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(Cashier_name, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                    else
                    {
                        errorName.SetError(Cashier_name, "");
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }
            }
        }

        private void CCsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = CCsum.Text;
            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(CCsum, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                {
                    errorNumeric.SetError(CCsum, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
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
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(CCsum, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        private void Cashsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = Cashsum.Text;
            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(Cashsum, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                {
                    errorNumeric.SetError(Cashsum, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
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
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(Cashsum, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        private void Refundsum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = Refundsum.Text;

            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(Refundsum, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                {
                    errorNumeric.SetError(Refundsum, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
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
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(Refundsum, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    check_refunds();
                }
            }
        }

        private void given_money_sum_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = given_money_sum.Text;
            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(given_money_sum, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                {
                    errorNumeric.SetError(given_money_sum, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
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
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(given_money_sum, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
        }

        private void receptor_name_TextChanged(object sender, EventArgs e)
        {
            string str = receptor_name.Text;
            if (str.Trim().Length == 0)
            {
                errorName.SetError(receptor_name, "Это поле не должно быть пустым. Укажите фамилию кассира.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(receptor_name, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                    else
                    {
                        errorName.SetError(receptor_name, "");
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int point = 0;
            string str = textBox1.Text;

            if (str.Trim().Length == 0)
                errorNumeric.SetError(textBox1, "Это поле не должно быть пустым.");
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                    errorNumeric.SetError(textBox1, "Это поле должно содержать число.");
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(textBox1, "Это поле должно содержать число.");
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(textBox1, "");
                    check_refunds();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int point = 0;
            string str = textBox2.Text;

            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(textBox2, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (point >= 1)
                {
                    errorNumeric.SetError(textBox2, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                if (!char.IsNumber(str[i]))
                {
                    if (str[i] == ',')
                    {
                        point++;
                        continue;
                    }
                    else
                    {
                        errorNumeric.SetError(textBox2, "Это поле должно содержать число.");
                        button2.Enabled = false;
                        button3.Enabled = false;
                        break;
                    }
                }
                else
                {
                    errorNumeric.SetError(textBox2, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    check_refunds();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str = textBox3.Text;

            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(textBox3, "Это поле не должно быть пустым.");
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    errorNumeric.SetError(textBox3, "Это поле должно содержать число.");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    break;
                }
                else
                {
                    errorNumeric.SetError(textBox3, "");
                    button2.Enabled = true;
                    button3.Enabled = true;
                    check_refunds();
                }
            }
        }
    }
}
