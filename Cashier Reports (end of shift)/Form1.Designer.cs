﻿
namespace Cashier_Reports__end_of_shift_
{
    partial class EOSReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cashier = new System.Windows.Forms.TextBox();
            this.Cashiername = new System.Windows.Forms.Label();
            this.Sumlabel = new System.Windows.Forms.Label();
            this.CCsum = new System.Windows.Forms.TextBox();
            this.Cashsumlabel = new System.Windows.Forms.Label();
            this.Cashsum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Refunds = new System.Windows.Forms.TableLayoutPanel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Refundsum = new System.Windows.Forms.TextBox();
            this.Refundslabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Refunds.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cashier
            // 
            this.Cashier.Location = new System.Drawing.Point(471, 12);
            this.Cashier.Name = "Cashier";
            this.Cashier.Size = new System.Drawing.Size(185, 26);
            this.Cashier.TabIndex = 0;
            this.Cashier.Text = "Фамилия И.О.";
            // 
            // Cashiername
            // 
            this.Cashiername.AutoSize = true;
            this.Cashiername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashiername.Location = new System.Drawing.Point(397, 15);
            this.Cashiername.Name = "Cashiername";
            this.Cashiername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cashiername.Size = new System.Drawing.Size(68, 20);
            this.Cashiername.TabIndex = 1;
            this.Cashiername.Text = "Кассир";
            this.Cashiername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cashiername.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sumlabel
            // 
            this.Sumlabel.AutoSize = true;
            this.Sumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumlabel.Location = new System.Drawing.Point(15, 61);
            this.Sumlabel.Name = "Sumlabel";
            this.Sumlabel.Size = new System.Drawing.Size(450, 20);
            this.Sumlabel.TabIndex = 2;
            this.Sumlabel.Text = "Сумма прихода по кредитным картам (отчёт Opera)";
            this.Sumlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CCsum
            // 
            this.CCsum.Location = new System.Drawing.Point(471, 58);
            this.CCsum.Name = "CCsum";
            this.CCsum.Size = new System.Drawing.Size(185, 26);
            this.CCsum.TabIndex = 3;
            this.CCsum.Text = "0.00";
            // 
            // Cashsumlabel
            // 
            this.Cashsumlabel.AutoSize = true;
            this.Cashsumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashsumlabel.Location = new System.Drawing.Point(214, 107);
            this.Cashsumlabel.Name = "Cashsumlabel";
            this.Cashsumlabel.Size = new System.Drawing.Size(251, 20);
            this.Cashsumlabel.TabIndex = 4;
            this.Cashsumlabel.Text = "Сумма инкассации наличных";
            this.Cashsumlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cashsum
            // 
            this.Cashsum.Location = new System.Drawing.Point(471, 104);
            this.Cashsum.Name = "Cashsum";
            this.Cashsum.Size = new System.Drawing.Size(185, 26);
            this.Cashsum.TabIndex = 5;
            this.Cashsum.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Refunds);
            this.groupBox1.Controls.Add(this.Refundsum);
            this.groupBox1.Controls.Add(this.Refundslabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 469);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возвраты";
            // 
            // Refunds
            // 
            this.Refunds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Refunds.AutoScroll = true;
            this.Refunds.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Refunds.ColumnCount = 2;
            this.Refunds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.52461F));
            this.Refunds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.47539F));
            this.Refunds.Controls.Add(this.textBox20, 0, 8);
            this.Refunds.Controls.Add(this.textBox19, 0, 7);
            this.Refunds.Controls.Add(this.textBox6, 0, 7);
            this.Refunds.Controls.Add(this.textBox5, 0, 7);
            this.Refunds.Controls.Add(this.label6, 1, 0);
            this.Refunds.Controls.Add(this.textBox17, 0, 6);
            this.Refunds.Controls.Add(this.textBox18, 1, 6);
            this.Refunds.Controls.Add(this.textBox15, 0, 5);
            this.Refunds.Controls.Add(this.textBox16, 1, 5);
            this.Refunds.Controls.Add(this.textBox13, 0, 4);
            this.Refunds.Controls.Add(this.textBox14, 1, 4);
            this.Refunds.Controls.Add(this.textBox11, 0, 3);
            this.Refunds.Controls.Add(this.textBox12, 1, 3);
            this.Refunds.Controls.Add(this.textBox9, 0, 2);
            this.Refunds.Controls.Add(this.textBox10, 1, 2);
            this.Refunds.Controls.Add(this.textBox7, 0, 1);
            this.Refunds.Controls.Add(this.textBox8, 1, 1);
            this.Refunds.Controls.Add(this.label5, 0, 0);
            this.Refunds.Location = new System.Drawing.Point(17, 75);
            this.Refunds.Name = "Refunds";
            this.Refunds.RowCount = 9;
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Refunds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Refunds.Size = new System.Drawing.Size(387, 321);
            this.Refunds.TabIndex = 7;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(108, 285);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(274, 26);
            this.textBox20.TabIndex = 17;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(5, 250);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(95, 26);
            this.textBox19.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 250);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 26);
            this.textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(5, 285);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(95, 26);
            this.textBox5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Сумма возврата";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(5, 215);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(95, 26);
            this.textBox17.TabIndex = 12;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(108, 215);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(274, 26);
            this.textBox18.TabIndex = 13;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(5, 180);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(95, 26);
            this.textBox15.TabIndex = 10;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(108, 180);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(274, 26);
            this.textBox16.TabIndex = 11;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(5, 145);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(95, 26);
            this.textBox13.TabIndex = 8;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(108, 145);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(274, 26);
            this.textBox14.TabIndex = 9;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(5, 110);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(95, 26);
            this.textBox11.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(108, 110);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(274, 26);
            this.textBox12.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(5, 75);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(95, 26);
            this.textBox9.TabIndex = 4;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(108, 75);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(274, 26);
            this.textBox10.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(5, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 26);
            this.textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(108, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(274, 26);
            this.textBox8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "№ чека";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Refundsum
            // 
            this.Refundsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refundsum.Location = new System.Drawing.Point(235, 30);
            this.Refundsum.Name = "Refundsum";
            this.Refundsum.Size = new System.Drawing.Size(185, 26);
            this.Refundsum.TabIndex = 6;
            this.Refundsum.Text = "0.00";
            // 
            // Refundslabel
            // 
            this.Refundslabel.AutoSize = true;
            this.Refundslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refundslabel.Location = new System.Drawing.Point(13, 33);
            this.Refundslabel.Name = "Refundslabel";
            this.Refundslabel.Size = new System.Drawing.Size(216, 20);
            this.Refundslabel.TabIndex = 5;
            this.Refundslabel.Text = "Общая сумма возвратов";
            this.Refundslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Сумма переданный наличных";
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(283, 30);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(185, 26);
            this.textBox21.TabIndex = 8;
            this.textBox21.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 128);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приходный кассовый ордер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 83);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(227, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Кому переданы наличные";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(283, 80);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(185, 26);
            this.textBox22.TabIndex = 9;
            this.textBox22.Text = "Фамилия И.О.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 62);
            this.button2.TabIndex = 10;
            this.button2.Text = "Просмотр отчётов";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(605, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(351, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "Печать отчётов";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(605, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(351, 62);
            this.button4.TabIndex = 12;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox23
            // 
            this.textBox23.Enabled = false;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(339, 416);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(65, 26);
            this.textBox23.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Всё верно ?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EOSReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cashsum);
            this.Controls.Add(this.Cashsumlabel);
            this.Controls.Add(this.CCsum);
            this.Controls.Add(this.Sumlabel);
            this.Controls.Add(this.Cashiername);
            this.Controls.Add(this.Cashier);
            this.Controls.Add(this.groupBox1);
            this.Name = "EOSReports";
            this.Text = "Отчёты конца смены";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Refunds.ResumeLayout(false);
            this.Refunds.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cashier;
        private System.Windows.Forms.Label Cashiername;
        private System.Windows.Forms.Label Sumlabel;
        private System.Windows.Forms.TextBox CCsum;
        private System.Windows.Forms.Label Cashsumlabel;
        private System.Windows.Forms.TextBox Cashsum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Refundsum;
        private System.Windows.Forms.Label Refundslabel;
        private System.Windows.Forms.TableLayoutPanel Refunds;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label9;
    }
}

