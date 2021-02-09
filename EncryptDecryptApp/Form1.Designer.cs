namespace EncryptDecryptApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sep1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Mode1Opt1 = new System.Windows.Forms.RadioButton();
            this.Mode1Opt2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mode2Opt1 = new System.Windows.Forms.RadioButton();
            this.Mode2Opt2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlainBox = new System.Windows.Forms.TextBox();
            this.AlphaBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.AlphaBox2 = new System.Windows.Forms.TextBox();
            this.StepBox = new System.Windows.Forms.NumericUpDown();
            this.PFileBox = new System.Windows.Forms.TextBox();
            this.KFileBox = new System.Windows.Forms.TextBox();
            this.PFileCheck = new System.Windows.Forms.CheckBox();
            this.KFileCheck = new System.Windows.Forms.CheckBox();
            this.RFileCheck = new System.Windows.Forms.CheckBox();
            this.RFileBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метод :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Явно съобщение :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Азбука (име на файл) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ключ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Азбука на резултата :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стъпка :";
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.MintCream;
            this.ResultBox.Location = new System.Drawing.Point(195, 302);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(123, 45);
            this.ResultBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Резултат :";
            // 
            // Sep1
            // 
            this.Sep1.BackColor = System.Drawing.Color.Black;
            this.Sep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sep1.Location = new System.Drawing.Point(5, 61);
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(570, 4);
            this.Sep1.TabIndex = 10;
            this.Sep1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Button1
            // 
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Location = new System.Drawing.Point(13, 297);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 54);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Криптиране";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Items.AddRange(new object[] {
            "Шифър на Цезар (с променлива стъпка)",
            "Директно Заместване",
            "Многоазбучно Заместване",
            "Матрично Заместване",
            "Транспозиционно с Блокуване",
            "Транспозиционно с Форматиране"});
            this.Combo.Location = new System.Drawing.Point(63, 20);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(223, 21);
            this.Combo.TabIndex = 12;
            this.Combo.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(5, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(570, 4);
            this.label7.TabIndex = 13;
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Mode1Opt1
            // 
            this.Mode1Opt1.AutoSize = true;
            this.Mode1Opt1.Location = new System.Drawing.Point(16, 8);
            this.Mode1Opt1.Name = "Mode1Opt1";
            this.Mode1Opt1.Size = new System.Drawing.Size(85, 17);
            this.Mode1Opt1.TabIndex = 14;
            this.Mode1Opt1.TabStop = true;
            this.Mode1Opt1.Text = "Криптиране";
            this.Mode1Opt1.UseVisualStyleBackColor = true;
            this.Mode1Opt1.CheckedChanged += new System.EventHandler(this.Mode1Opt1_CheckedChanged);
            // 
            // Mode1Opt2
            // 
            this.Mode1Opt2.AutoSize = true;
            this.Mode1Opt2.Location = new System.Drawing.Point(16, 31);
            this.Mode1Opt2.Name = "Mode1Opt2";
            this.Mode1Opt2.Size = new System.Drawing.Size(99, 17);
            this.Mode1Opt2.TabIndex = 15;
            this.Mode1Opt2.TabStop = true;
            this.Mode1Opt2.Text = "Декриптиране";
            this.Mode1Opt2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mode1Opt2);
            this.groupBox1.Controls.Add(this.Mode1Opt1);
            this.groupBox1.Location = new System.Drawing.Point(296, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 56);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Mode2Opt1
            // 
            this.Mode2Opt1.AutoSize = true;
            this.Mode2Opt1.Location = new System.Drawing.Point(10, 8);
            this.Mode2Opt1.Name = "Mode2Opt1";
            this.Mode2Opt1.Size = new System.Drawing.Size(105, 17);
            this.Mode2Opt1.TabIndex = 17;
            this.Mode2Opt1.TabStop = true;
            this.Mode2Opt1.Text = "Буквена азбука";
            this.Mode2Opt1.UseVisualStyleBackColor = true;
            this.Mode2Opt1.CheckedChanged += new System.EventHandler(this.Mode2Opt1_CheckedChanged);
            // 
            // Mode2Opt2
            // 
            this.Mode2Opt2.AutoSize = true;
            this.Mode2Opt2.Location = new System.Drawing.Point(10, 31);
            this.Mode2Opt2.Name = "Mode2Opt2";
            this.Mode2Opt2.Size = new System.Drawing.Size(109, 17);
            this.Mode2Opt2.TabIndex = 18;
            this.Mode2Opt2.TabStop = true;
            this.Mode2Opt2.Text = "Цифрова азбука";
            this.Mode2Opt2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Mode2Opt2);
            this.groupBox2.Controls.Add(this.Mode2Opt1);
            this.groupBox2.Location = new System.Drawing.Point(440, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 55);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // PlainBox
            // 
            this.PlainBox.Location = new System.Drawing.Point(133, 91);
            this.PlainBox.Name = "PlainBox";
            this.PlainBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PlainBox.Size = new System.Drawing.Size(153, 20);
            this.PlainBox.TabIndex = 20;
            // 
            // AlphaBox
            // 
            this.AlphaBox.Location = new System.Drawing.Point(133, 124);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Size = new System.Drawing.Size(153, 20);
            this.AlphaBox.TabIndex = 21;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(133, 153);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(153, 20);
            this.KeyBox.TabIndex = 22;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // AlphaBox2
            // 
            this.AlphaBox2.Location = new System.Drawing.Point(133, 201);
            this.AlphaBox2.Name = "AlphaBox2";
            this.AlphaBox2.Size = new System.Drawing.Size(153, 20);
            this.AlphaBox2.TabIndex = 23;
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(133, 233);
            this.StepBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.StepBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(63, 20);
            this.StepBox.TabIndex = 24;
            this.StepBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // PFileBox
            // 
            this.PFileBox.Location = new System.Drawing.Point(421, 90);
            this.PFileBox.Name = "PFileBox";
            this.PFileBox.Size = new System.Drawing.Size(153, 20);
            this.PFileBox.TabIndex = 25;
            // 
            // KFileBox
            // 
            this.KFileBox.Location = new System.Drawing.Point(422, 153);
            this.KFileBox.Name = "KFileBox";
            this.KFileBox.Size = new System.Drawing.Size(153, 20);
            this.KFileBox.TabIndex = 26;
            this.KFileBox.TextChanged += new System.EventHandler(this.KFileBox_TextChanged);
            // 
            // PFileCheck
            // 
            this.PFileCheck.AutoSize = true;
            this.PFileCheck.Location = new System.Drawing.Point(331, 91);
            this.PFileCheck.Name = "PFileCheck";
            this.PFileCheck.Size = new System.Drawing.Size(74, 17);
            this.PFileCheck.TabIndex = 27;
            this.PFileCheck.Text = "От файл :";
            this.PFileCheck.UseVisualStyleBackColor = true;
            this.PFileCheck.CheckedChanged += new System.EventHandler(this.PFileCheck_CheckedChanged);
            // 
            // KFileCheck
            // 
            this.KFileCheck.AutoSize = true;
            this.KFileCheck.Location = new System.Drawing.Point(331, 156);
            this.KFileCheck.Name = "KFileCheck";
            this.KFileCheck.Size = new System.Drawing.Size(74, 17);
            this.KFileCheck.TabIndex = 28;
            this.KFileCheck.Text = "От файл :";
            this.KFileCheck.UseVisualStyleBackColor = true;
            this.KFileCheck.CheckedChanged += new System.EventHandler(this.KFileCheck_CheckedChanged);
            // 
            // RFileCheck
            // 
            this.RFileCheck.AutoSize = true;
            this.RFileCheck.Location = new System.Drawing.Point(402, 302);
            this.RFileCheck.Name = "RFileCheck";
            this.RFileCheck.Size = new System.Drawing.Size(114, 17);
            this.RFileCheck.TabIndex = 30;
            this.RFileCheck.Text = "Запис във файл :";
            this.RFileCheck.UseVisualStyleBackColor = true;
            this.RFileCheck.CheckedChanged += new System.EventHandler(this.RFileCheck_CheckedChanged);
            // 
            // RFileBox
            // 
            this.RFileBox.Location = new System.Drawing.Point(402, 325);
            this.RFileBox.Name = "RFileBox";
            this.RFileBox.Size = new System.Drawing.Size(153, 20);
            this.RFileBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(586, 361);
            this.Controls.Add(this.RFileCheck);
            this.Controls.Add(this.RFileBox);
            this.Controls.Add(this.KFileCheck);
            this.Controls.Add(this.PFileCheck);
            this.Controls.Add(this.KFileBox);
            this.Controls.Add(this.PFileBox);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.AlphaBox2);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.AlphaBox);
            this.Controls.Add(this.PlainBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Sep1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "EncryptDecryptApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Sep1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Mode1Opt1;
        private System.Windows.Forms.RadioButton Mode1Opt2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Mode2Opt1;
        private System.Windows.Forms.RadioButton Mode2Opt2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PlainBox;
        private System.Windows.Forms.TextBox AlphaBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox AlphaBox2;
        private System.Windows.Forms.NumericUpDown StepBox;
        private System.Windows.Forms.TextBox PFileBox;
        private System.Windows.Forms.TextBox KFileBox;
        private System.Windows.Forms.CheckBox PFileCheck;
        private System.Windows.Forms.CheckBox KFileCheck;
        private System.Windows.Forms.CheckBox RFileCheck;
        private System.Windows.Forms.TextBox RFileBox;
    }
}

