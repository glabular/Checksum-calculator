namespace HashsumCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSHA256 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBarSHA256 = new System.Windows.Forms.ProgressBar();
            this.checkBoxSHA256 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA384 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA512 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA1 = new System.Windows.Forms.CheckBox();
            this.checkBoxMD5 = new System.Windows.Forms.CheckBox();
            this.textBoxSHA384 = new System.Windows.Forms.TextBox();
            this.progressBarSHA384 = new System.Windows.Forms.ProgressBar();
            this.textBoxSHA512 = new System.Windows.Forms.TextBox();
            this.textBoxSHA1 = new System.Windows.Forms.TextBox();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.progressBarSHA512 = new System.Windows.Forms.ProgressBar();
            this.progressBarSHA1 = new System.Windows.Forms.ProgressBar();
            this.progressBarMD5 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAllAlgorithms = new System.Windows.Forms.CheckBox();
            this.buttonCopySHA256 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCopyMD5 = new System.Windows.Forms.Button();
            this.buttonCopySHA1 = new System.Windows.Forms.Button();
            this.buttonCopySHA512 = new System.Windows.Forms.Button();
            this.buttonCopySHA384 = new System.Windows.Forms.Button();
            this.checkBoxEatRAM = new System.Windows.Forms.CheckBox();
            this.checkBoxStopWatch = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 119);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Перетащите файл сюда";
            // 
            // textBoxSHA256
            // 
            this.textBoxSHA256.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA256.Location = new System.Drawing.Point(71, 22);
            this.textBoxSHA256.Name = "textBoxSHA256";
            this.textBoxSHA256.ReadOnly = true;
            this.textBoxSHA256.Size = new System.Drawing.Size(538, 27);
            this.textBoxSHA256.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(315, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Нижний регистр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // progressBarSHA256
            // 
            this.progressBarSHA256.Location = new System.Drawing.Point(71, 22);
            this.progressBarSHA256.Name = "progressBarSHA256";
            this.progressBarSHA256.Size = new System.Drawing.Size(538, 27);
            this.progressBarSHA256.TabIndex = 5;
            this.progressBarSHA256.Visible = false;
            // 
            // checkBoxSHA256
            // 
            this.checkBoxSHA256.AutoSize = true;
            this.checkBoxSHA256.Location = new System.Drawing.Point(6, 22);
            this.checkBoxSHA256.Name = "checkBoxSHA256";
            this.checkBoxSHA256.Size = new System.Drawing.Size(67, 19);
            this.checkBoxSHA256.TabIndex = 6;
            this.checkBoxSHA256.Text = "SHA256";
            this.checkBoxSHA256.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA384
            // 
            this.checkBoxSHA384.AutoSize = true;
            this.checkBoxSHA384.Location = new System.Drawing.Point(6, 47);
            this.checkBoxSHA384.Name = "checkBoxSHA384";
            this.checkBoxSHA384.Size = new System.Drawing.Size(67, 19);
            this.checkBoxSHA384.TabIndex = 7;
            this.checkBoxSHA384.Text = "SHA384";
            this.checkBoxSHA384.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA512
            // 
            this.checkBoxSHA512.AutoSize = true;
            this.checkBoxSHA512.Location = new System.Drawing.Point(6, 72);
            this.checkBoxSHA512.Name = "checkBoxSHA512";
            this.checkBoxSHA512.Size = new System.Drawing.Size(67, 19);
            this.checkBoxSHA512.TabIndex = 8;
            this.checkBoxSHA512.Text = "SHA512";
            this.checkBoxSHA512.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA1
            // 
            this.checkBoxSHA1.AutoSize = true;
            this.checkBoxSHA1.Checked = true;
            this.checkBoxSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSHA1.Location = new System.Drawing.Point(91, 22);
            this.checkBoxSHA1.Name = "checkBoxSHA1";
            this.checkBoxSHA1.Size = new System.Drawing.Size(55, 19);
            this.checkBoxSHA1.TabIndex = 9;
            this.checkBoxSHA1.Text = "SHA1";
            this.checkBoxSHA1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMD5
            // 
            this.checkBoxMD5.AutoSize = true;
            this.checkBoxMD5.Location = new System.Drawing.Point(91, 47);
            this.checkBoxMD5.Name = "checkBoxMD5";
            this.checkBoxMD5.Size = new System.Drawing.Size(51, 19);
            this.checkBoxMD5.TabIndex = 10;
            this.checkBoxMD5.Text = "MD5";
            this.checkBoxMD5.UseVisualStyleBackColor = true;
            this.checkBoxMD5.CheckedChanged += new System.EventHandler(this.checkBoxMD5_CheckedChanged);
            // 
            // textBoxSHA384
            // 
            this.textBoxSHA384.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA384.Location = new System.Drawing.Point(71, 55);
            this.textBoxSHA384.Name = "textBoxSHA384";
            this.textBoxSHA384.ReadOnly = true;
            this.textBoxSHA384.Size = new System.Drawing.Size(538, 27);
            this.textBoxSHA384.TabIndex = 1;
            // 
            // progressBarSHA384
            // 
            this.progressBarSHA384.Location = new System.Drawing.Point(71, 55);
            this.progressBarSHA384.Name = "progressBarSHA384";
            this.progressBarSHA384.Size = new System.Drawing.Size(538, 27);
            this.progressBarSHA384.TabIndex = 5;
            this.progressBarSHA384.Visible = false;
            // 
            // textBoxSHA512
            // 
            this.textBoxSHA512.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA512.Location = new System.Drawing.Point(71, 88);
            this.textBoxSHA512.Name = "textBoxSHA512";
            this.textBoxSHA512.ReadOnly = true;
            this.textBoxSHA512.Size = new System.Drawing.Size(538, 27);
            this.textBoxSHA512.TabIndex = 1;
            // 
            // textBoxSHA1
            // 
            this.textBoxSHA1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA1.Location = new System.Drawing.Point(71, 121);
            this.textBoxSHA1.Name = "textBoxSHA1";
            this.textBoxSHA1.ReadOnly = true;
            this.textBoxSHA1.Size = new System.Drawing.Size(538, 27);
            this.textBoxSHA1.TabIndex = 1;
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMD5.Location = new System.Drawing.Point(71, 154);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.ReadOnly = true;
            this.textBoxMD5.Size = new System.Drawing.Size(538, 27);
            this.textBoxMD5.TabIndex = 1;
            // 
            // progressBarSHA512
            // 
            this.progressBarSHA512.Location = new System.Drawing.Point(71, 88);
            this.progressBarSHA512.Name = "progressBarSHA512";
            this.progressBarSHA512.Size = new System.Drawing.Size(538, 27);
            this.progressBarSHA512.TabIndex = 5;
            this.progressBarSHA512.Visible = false;
            // 
            // progressBarSHA1
            // 
            this.progressBarSHA1.Location = new System.Drawing.Point(71, 121);
            this.progressBarSHA1.Name = "progressBarSHA1";
            this.progressBarSHA1.Size = new System.Drawing.Size(538, 27);
            this.progressBarSHA1.TabIndex = 5;
            this.progressBarSHA1.Visible = false;
            // 
            // progressBarMD5
            // 
            this.progressBarMD5.Location = new System.Drawing.Point(71, 154);
            this.progressBarMD5.Name = "progressBarMD5";
            this.progressBarMD5.Size = new System.Drawing.Size(538, 27);
            this.progressBarMD5.TabIndex = 5;
            this.progressBarMD5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "SHA256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "SHA384";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "SHA512";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "SHA1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "MD5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSelectAllAlgorithms);
            this.groupBox1.Controls.Add(this.checkBoxSHA256);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxSHA384);
            this.groupBox1.Controls.Add(this.checkBoxSHA512);
            this.groupBox1.Controls.Add(this.checkBoxSHA1);
            this.groupBox1.Controls.Add(this.checkBoxMD5);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритмы хэширования";
            // 
            // checkBoxSelectAllAlgorithms
            // 
            this.checkBoxSelectAllAlgorithms.AutoSize = true;
            this.checkBoxSelectAllAlgorithms.Location = new System.Drawing.Point(91, 72);
            this.checkBoxSelectAllAlgorithms.Name = "checkBoxSelectAllAlgorithms";
            this.checkBoxSelectAllAlgorithms.Size = new System.Drawing.Size(94, 19);
            this.checkBoxSelectAllAlgorithms.TabIndex = 13;
            this.checkBoxSelectAllAlgorithms.Text = "Выбрать все";
            this.checkBoxSelectAllAlgorithms.UseVisualStyleBackColor = true;
            this.checkBoxSelectAllAlgorithms.CheckedChanged += new System.EventHandler(this.checkBoxSelectAllAlgorithms_CheckedChanged);
            // 
            // buttonCopySHA256
            // 
            this.buttonCopySHA256.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256.Image")));
            this.buttonCopySHA256.Location = new System.Drawing.Point(615, 23);
            this.buttonCopySHA256.Name = "buttonCopySHA256";
            this.buttonCopySHA256.Size = new System.Drawing.Size(48, 27);
            this.buttonCopySHA256.TabIndex = 14;
            this.buttonCopySHA256.UseVisualStyleBackColor = true;
            this.buttonCopySHA256.Click += new System.EventHandler(this.buttonCopySHA256_Click);
            this.buttonCopySHA256.MouseHover += new System.EventHandler(this.buttonCopyToClipboard_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.progressBarSHA256);
            this.groupBox2.Controls.Add(this.buttonCopyMD5);
            this.groupBox2.Controls.Add(this.buttonCopySHA1);
            this.groupBox2.Controls.Add(this.buttonCopySHA512);
            this.groupBox2.Controls.Add(this.buttonCopySHA384);
            this.groupBox2.Controls.Add(this.buttonCopySHA256);
            this.groupBox2.Controls.Add(this.textBoxSHA256);
            this.groupBox2.Controls.Add(this.progressBarSHA384);
            this.groupBox2.Controls.Add(this.progressBarSHA512);
            this.groupBox2.Controls.Add(this.textBoxSHA512);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxSHA384);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBarMD5);
            this.groupBox2.Controls.Add(this.progressBarSHA1);
            this.groupBox2.Controls.Add(this.textBoxSHA1);
            this.groupBox2.Controls.Add(this.textBoxMD5);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 220);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статус: ОК";
            this.groupBox2.MouseHover += new System.EventHandler(this.groupBox2_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Очистить всё";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCopyMD5
            // 
            this.buttonCopyMD5.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5.Image")));
            this.buttonCopyMD5.Location = new System.Drawing.Point(615, 155);
            this.buttonCopyMD5.Name = "buttonCopyMD5";
            this.buttonCopyMD5.Size = new System.Drawing.Size(48, 27);
            this.buttonCopyMD5.TabIndex = 14;
            this.buttonCopyMD5.UseVisualStyleBackColor = true;
            this.buttonCopyMD5.Click += new System.EventHandler(this.buttonCopyMD5_Click);
            this.buttonCopyMD5.MouseHover += new System.EventHandler(this.buttonCopyToClipboard_MouseHover);
            // 
            // buttonCopySHA1
            // 
            this.buttonCopySHA1.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1.Image")));
            this.buttonCopySHA1.Location = new System.Drawing.Point(615, 122);
            this.buttonCopySHA1.Name = "buttonCopySHA1";
            this.buttonCopySHA1.Size = new System.Drawing.Size(48, 27);
            this.buttonCopySHA1.TabIndex = 14;
            this.buttonCopySHA1.UseVisualStyleBackColor = true;
            this.buttonCopySHA1.Click += new System.EventHandler(this.buttonCopySHA1_Click);
            this.buttonCopySHA1.MouseHover += new System.EventHandler(this.buttonCopyToClipboard_MouseHover);
            // 
            // buttonCopySHA512
            // 
            this.buttonCopySHA512.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512.Image")));
            this.buttonCopySHA512.Location = new System.Drawing.Point(615, 89);
            this.buttonCopySHA512.Name = "buttonCopySHA512";
            this.buttonCopySHA512.Size = new System.Drawing.Size(48, 27);
            this.buttonCopySHA512.TabIndex = 14;
            this.buttonCopySHA512.UseVisualStyleBackColor = true;
            this.buttonCopySHA512.Click += new System.EventHandler(this.buttonCopySHA512_Click);
            this.buttonCopySHA512.MouseHover += new System.EventHandler(this.buttonCopyToClipboard_MouseHover);
            // 
            // buttonCopySHA384
            // 
            this.buttonCopySHA384.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384.Image")));
            this.buttonCopySHA384.Location = new System.Drawing.Point(615, 56);
            this.buttonCopySHA384.Name = "buttonCopySHA384";
            this.buttonCopySHA384.Size = new System.Drawing.Size(48, 27);
            this.buttonCopySHA384.TabIndex = 14;
            this.buttonCopySHA384.UseVisualStyleBackColor = true;
            this.buttonCopySHA384.Click += new System.EventHandler(this.buttonCopySHA384_Click);
            this.buttonCopySHA384.MouseHover += new System.EventHandler(this.buttonCopyToClipboard_MouseHover);
            // 
            // checkBoxEatRAM
            // 
            this.checkBoxEatRAM.AutoSize = true;
            this.checkBoxEatRAM.Location = new System.Drawing.Point(535, 31);
            this.checkBoxEatRAM.Name = "checkBoxEatRAM";
            this.checkBoxEatRAM.Size = new System.Drawing.Size(126, 19);
            this.checkBoxEatRAM.TabIndex = 16;
            this.checkBoxEatRAM.Text = "Сверхрасход RAM";
            this.checkBoxEatRAM.UseVisualStyleBackColor = true;
            this.checkBoxEatRAM.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxStopWatch
            // 
            this.checkBoxStopWatch.AutoSize = true;
            this.checkBoxStopWatch.Location = new System.Drawing.Point(535, 56);
            this.checkBoxStopWatch.Name = "checkBoxStopWatch";
            this.checkBoxStopWatch.Size = new System.Drawing.Size(94, 19);
            this.checkBoxStopWatch.TabIndex = 17;
            this.checkBoxStopWatch.Text = "Секундомер";
            this.checkBoxStopWatch.UseVisualStyleBackColor = true;
            this.checkBoxStopWatch.CheckedChanged += new System.EventHandler(this.checkBoxStopWatch_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 392);
            this.Controls.Add(this.checkBoxStopWatch);
            this.Controls.Add(this.checkBoxEatRAM);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Калькулятор чек-сумм";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox textBoxSHA256;
        private CheckBox checkBox1;
        private Label label2;
        private ProgressBar progressBarSHA256;
        private CheckBox checkBoxSHA256;
        private CheckBox checkBoxSHA384;
        private CheckBox checkBoxSHA512;
        private CheckBox checkBoxSHA1;
        private CheckBox checkBoxMD5;
        private TextBox textBoxSHA384;
        private ProgressBar progressBarSHA384;
        private TextBox textBoxSHA512;
        private TextBox textBoxSHA1;
        private TextBox textBoxMD5;
        private ProgressBar progressBarSHA512;
        private ProgressBar progressBarSHA1;
        private ProgressBar progressBarMD5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private GroupBox groupBox1;
        private Button buttonCopySHA256;
        private CheckBox checkBoxSelectAllAlgorithms;
        private GroupBox groupBox2;
        private Button buttonCopyMD5;
        private Button buttonCopySHA1;
        private Button buttonCopySHA512;
        private Button buttonCopySHA384;
        private Button button2;
        private CheckBox checkBoxEatRAM;
        private CheckBox checkBoxStopWatch;
        private Button button3;
    }
}