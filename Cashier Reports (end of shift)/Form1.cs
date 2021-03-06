using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            if (Properties.Settings.Default.Checkbox == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
            Login login_window = new Login();
            New_user user_window = new New_user();
            if (login_window.ShowDialog() == DialogResult.No)
            {
                if (user_window.ShowDialog() == DialogResult.OK)
                {
                    Cashier_name.Text = Properties.Settings.Default.Cashier_name;
                    textBox3.Text = Properties.Settings.Default.Cashier_number;
                    comboBox1.Text = Properties.Settings.Default.Cashier;
                }
                else
                {
                    Cashier_name.Text = "Фамилия И. О.";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                }
            }
            else
            {
                var Login = Path.Combine(Directory.GetCurrentDirectory(), "Login.xls");

                Excel.Application xlLog = new Excel.Application();
                xlLog.Visible = false;

                Excel.Workbook xlLogworkbook = xlLog.Workbooks.Open(Login);

                Excel.Sheets xlLogsheets = xlLogworkbook.Worksheets;
                Excel.Worksheet xlLogins = (Excel.Worksheet)xlLogsheets.get_Item("Users");

                int i = Properties.Settings.Default.i;
                Console.WriteLine(i);
                Cashier_name.Text = (string)(xlLogins.Cells[i, "B"] as Excel.Range).Value;
                textBox3.Text = (string)(xlLogins.Cells[i, "C"] as Excel.Range).Value.ToString();
                comboBox1.Text = (string)(xlLogins.Cells[i, "D"] as Excel.Range).Value.ToString();
                xlLogworkbook.Close(false);
            }
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
                string Pri2 = "Приходник (2 лист)";

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
                    Excel.Worksheet xlPri2 = (Excel.Worksheet)xlRepsheets.get_Item(Pri2);

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

                        xlPri2.Cells[8, "BA"] = comboBox1.Text;
                        xlPri2.Cells[20, "E"] = textBox3.Text;
                        xlPri2.Cells[20, "AO"] = given_money_sum.Text;
                        xlPri2.Cells[54, "Y"] = Cashier_name.Text;
                        xlPri2.Cells[22, "F"] = receptor_name.Text;
                        xlPri2.PrintOutEx();
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
                string Pri2 = "Приходник (2 лист)";

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
                    Excel.Worksheet xlPri2 = (Excel.Worksheet)xlRepsheets.get_Item(Pri2);

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

                        xlPri2.Cells[8, "BA"] = comboBox1.Text;
                        xlPri2.Cells[20, "E"] = textBox3.Text;
                        xlPri2.Cells[20, "AO"] = given_money_sum.Text;
                        xlPri2.Cells[54, "Y"] = Cashier_name.Text;
                        xlPri2.Cells[22, "F"] = receptor_name.Text;
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
                        textBox4.Text = Cashier_name.Text;
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
                    textBox5.Text = textBox3.Text;
                    check_refunds();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string str = textBox4.Text;
            if (str.Trim().Length == 0)
            {
                errorName.SetError(textBox4, "Это поле не должно быть пустым. Укажите фамилию кассира.");
                button1.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsNumber(str[i]))
                    {
                        errorName.SetError(textBox4, "Это поле должно содержать только буквы, в соответствии со структурой Фамилия И.О.");
                        button1.Enabled = false;
                        button4.Enabled = false;
                        break;
                    }
                    else
                    {
                        errorName.SetError(textBox4, "");
                        button1.Enabled = true;
                        button4.Enabled = true;
                    }
                }
            }
        }

        private void Change_forecolors_to_black()
        {
            Cashiername.ForeColor = Color.Black;
            Sumlabel.ForeColor = Color.Black;
            Cashsumlabel.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            Refundslabel.ForeColor = Color.Black;
            Given_mon_label.ForeColor = Color.Black;
            receptor_label.ForeColor = Color.Black;
            Correctlabel.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
            refunds_group.ForeColor = Color.Black;
            arrivals_group.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            Check_num.ForeColor = Color.Black;
            Refsum_check.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            Quit.ForeColor = Color.Black;
            button1.BackColor = SystemColors.ButtonHighlight;
            button2.BackColor = SystemColors.ButtonHighlight;
            button3.BackColor = SystemColors.ButtonHighlight;
            button4.BackColor = SystemColors.ButtonHighlight;
            button5.BackColor = SystemColors.ButtonHighlight;
            button6.BackColor = SystemColors.ButtonHighlight;
            Quit.BackColor = SystemColors.ButtonHighlight;
            refunds_group.BackColor = SystemColors.Control;
            arrivals_group.BackColor = SystemColors.Control;
            groupBox1.BackColor = SystemColors.Control;
            groupBox2.BackColor = SystemColors.Control;
            groupBox3.BackColor = SystemColors.Control;
            Refunds.BackColor = SystemColors.Control;
        }

        private void Change_forecolors_to_white()
        {
            Cashiername.ForeColor = Color.White;
            Sumlabel.ForeColor = Color.White;
            Cashsumlabel.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            Refundslabel.ForeColor = Color.White;
            Given_mon_label.ForeColor = Color.White;
            receptor_label.ForeColor = Color.White;
            Correctlabel.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            checkBox1.ForeColor = Color.White;
            refunds_group.ForeColor = Color.White;
            arrivals_group.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
            Check_num.ForeColor = Color.White;
            Refsum_check.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            Quit.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            Quit.BackColor = Color.Black;
            refunds_group.BackColor = SystemColors.ControlDarkDark;
            arrivals_group.BackColor = SystemColors.ControlDarkDark;
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox3.BackColor = SystemColors.ControlDarkDark;
            Refunds.BackColor = SystemColors.ControlDarkDark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cashier_name = textBox4.Text;
            Cashier_name.Text = textBox4.Text;
            Properties.Settings.Default.Cashier_number = textBox5.Text;
            textBox3.Text = textBox5.Text;
            Properties.Settings.Default.Cashier = comboBox2.Text;
            comboBox1.Text = comboBox2.Text;
            if (checkBox1.Checked == true)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                tabPage1.BackColor = SystemColors.ControlDarkDark;
                tabPage2.BackColor = SystemColors.ControlDarkDark;
                tabPage3.BackColor = SystemColors.ControlDarkDark;
                Change_forecolors_to_white();
                Properties.Settings.Default.BackColorMain = SystemColors.ControlDarkDark;
                Properties.Settings.Default.ForeColorText = Color.White;
                Properties.Settings.Default.ButtonColor = Color.Black;
                Properties.Settings.Default.Checkbox = true;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                tabPage1.BackColor = SystemColors.Control;
                tabPage2.BackColor = SystemColors.Control;
                tabPage3.BackColor = SystemColors.Control;
                Change_forecolors_to_black();
                Properties.Settings.Default.BackColorMain = SystemColors.Control;
                Properties.Settings.Default.ForeColorText = Color.Black;
                Properties.Settings.Default.ButtonColor = SystemColors.ButtonHighlight;
                Properties.Settings.Default.Checkbox = false;
            }
            Properties.Settings.Default.Save();
            button1.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string str = textBox5.Text;

            if (str.Trim().Length == 0)
            {
                errorNumeric.SetError(textBox5, "Это поле не должно быть пустым.");
                button1.Enabled = false;
                button4.Enabled = false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    errorNumeric.SetError(textBox5, "Это поле должно содержать число.");
                    button1.Enabled = false;
                    button4.Enabled = false;
                    break;
                }
                else
                {
                    errorNumeric.SetError(textBox5, "");
                    button1.Enabled = true;
                    button4.Enabled = true;
                    check_refunds();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cashier_name = textBox4.Text;
            Properties.Settings.Default.Cashier_number = textBox5.Text;
            Properties.Settings.Default.Cashier = comboBox2.Text;
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.BackColorMain = SystemColors.ControlDarkDark;
                Properties.Settings.Default.ForeColorText = Color.White;
                Properties.Settings.Default.Checkbox = true;
            }
            else
            {
                Properties.Settings.Default.BackColorMain = SystemColors.Control;
                Properties.Settings.Default.ForeColorText = Color.Black;
                Properties.Settings.Default.Checkbox = false;
            }
            Properties.Settings.Default.Save();
            tabControl1.SelectedTab = tabPage1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
