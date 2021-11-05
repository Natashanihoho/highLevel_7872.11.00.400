
namespace PK_PPU
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxCollimators = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonInit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxMotor2 = new System.Windows.Forms.CheckBox();
            this.labelSpeed2 = new System.Windows.Forms.Label();
            this.buttonPlusSpeed2 = new System.Windows.Forms.Button();
            this.buttonMinusSpeed2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxMotor1 = new System.Windows.Forms.CheckBox();
            this.labelSpeed1 = new System.Windows.Forms.Label();
            this.buttonPlusSpeed1 = new System.Windows.Forms.Button();
            this.buttonMinusSpeed1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxHeat2 = new System.Windows.Forms.CheckBox();
            this.labelBr2 = new System.Windows.Forms.Label();
            this.buttonPlusBright2 = new System.Windows.Forms.Button();
            this.buttonMinusBright2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxHeat1 = new System.Windows.Forms.CheckBox();
            this.labelBr1 = new System.Windows.Forms.Label();
            this.buttonPlusBright1 = new System.Windows.Forms.Button();
            this.buttonMinusBright1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(12, 349);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(425, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт ";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxCollimators
            // 
            this.comboBoxCollimators.Enabled = false;
            this.comboBoxCollimators.FormattingEnabled = true;
            this.comboBoxCollimators.Location = new System.Drawing.Point(310, 38);
            this.comboBoxCollimators.Name = "comboBoxCollimators";
            this.comboBoxCollimators.Size = new System.Drawing.Size(98, 21);
            this.comboBoxCollimators.TabIndex = 1;
            this.comboBoxCollimators.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(307, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Коллиматор";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCom);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonInit);
            this.groupBox1.Controls.Add(this.comboBoxCollimators);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(182, 16);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(104, 13);
            this.labelCom.TabIndex = 6;
            this.labelCom.Text = "Port_____________";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(185, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 21);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonInit
            // 
            this.buttonInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInit.Location = new System.Drawing.Point(14, 16);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(151, 43);
            this.buttonInit.TabIndex = 5;
            this.buttonInit.Text = "Инициализация коллиматоров";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 255);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скорость";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxMotor2);
            this.groupBox7.Controls.Add(this.labelSpeed2);
            this.groupBox7.Controls.Add(this.buttonPlusSpeed2);
            this.groupBox7.Controls.Add(this.buttonMinusSpeed2);
            this.groupBox7.Location = new System.Drawing.Point(14, 131);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(171, 106);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Сетка 2";
            // 
            // checkBoxMotor2
            // 
            this.checkBoxMotor2.AutoSize = true;
            this.checkBoxMotor2.Enabled = false;
            this.checkBoxMotor2.Location = new System.Drawing.Point(15, 77);
            this.checkBoxMotor2.Name = "checkBoxMotor2";
            this.checkBoxMotor2.Size = new System.Drawing.Size(106, 17);
            this.checkBoxMotor2.TabIndex = 4;
            this.checkBoxMotor2.Text = "Пуск двигателя";
            this.checkBoxMotor2.UseVisualStyleBackColor = true;
            this.checkBoxMotor2.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // labelSpeed2
            // 
            this.labelSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed2.Location = new System.Drawing.Point(119, 19);
            this.labelSpeed2.Name = "labelSpeed2";
            this.labelSpeed2.Size = new System.Drawing.Size(46, 41);
            this.labelSpeed2.TabIndex = 3;
            this.labelSpeed2.Text = "0";
            this.labelSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusSpeed2
            // 
            this.buttonPlusSpeed2.Enabled = false;
            this.buttonPlusSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusSpeed2.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusSpeed2.Name = "buttonPlusSpeed2";
            this.buttonPlusSpeed2.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusSpeed2.TabIndex = 0;
            this.buttonPlusSpeed2.Text = "+";
            this.buttonPlusSpeed2.UseVisualStyleBackColor = true;
            this.buttonPlusSpeed2.Click += new System.EventHandler(this.buttonPlusSpeed2_Click);
            // 
            // buttonMinusSpeed2
            // 
            this.buttonMinusSpeed2.Enabled = false;
            this.buttonMinusSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusSpeed2.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusSpeed2.Name = "buttonMinusSpeed2";
            this.buttonMinusSpeed2.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusSpeed2.TabIndex = 0;
            this.buttonMinusSpeed2.Text = "-";
            this.buttonMinusSpeed2.UseVisualStyleBackColor = true;
            this.buttonMinusSpeed2.Click += new System.EventHandler(this.buttonMinusSpeed2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxMotor1);
            this.groupBox5.Controls.Add(this.labelSpeed1);
            this.groupBox5.Controls.Add(this.buttonPlusSpeed1);
            this.groupBox5.Controls.Add(this.buttonMinusSpeed1);
            this.groupBox5.Location = new System.Drawing.Point(14, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 106);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сетка 1";
            // 
            // checkBoxMotor1
            // 
            this.checkBoxMotor1.AutoSize = true;
            this.checkBoxMotor1.Enabled = false;
            this.checkBoxMotor1.Location = new System.Drawing.Point(15, 77);
            this.checkBoxMotor1.Name = "checkBoxMotor1";
            this.checkBoxMotor1.Size = new System.Drawing.Size(106, 17);
            this.checkBoxMotor1.TabIndex = 4;
            this.checkBoxMotor1.Text = "Пуск двигателя";
            this.checkBoxMotor1.UseVisualStyleBackColor = true;
            this.checkBoxMotor1.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // labelSpeed1
            // 
            this.labelSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed1.Location = new System.Drawing.Point(119, 20);
            this.labelSpeed1.Name = "labelSpeed1";
            this.labelSpeed1.Size = new System.Drawing.Size(46, 41);
            this.labelSpeed1.TabIndex = 3;
            this.labelSpeed1.Text = "0";
            this.labelSpeed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusSpeed1
            // 
            this.buttonPlusSpeed1.Enabled = false;
            this.buttonPlusSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusSpeed1.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusSpeed1.Name = "buttonPlusSpeed1";
            this.buttonPlusSpeed1.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusSpeed1.TabIndex = 0;
            this.buttonPlusSpeed1.Text = "+";
            this.buttonPlusSpeed1.UseVisualStyleBackColor = true;
            this.buttonPlusSpeed1.Click += new System.EventHandler(this.buttonPlusSpeed1_Click);
            // 
            // buttonMinusSpeed1
            // 
            this.buttonMinusSpeed1.Enabled = false;
            this.buttonMinusSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusSpeed1.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusSpeed1.Name = "buttonMinusSpeed1";
            this.buttonMinusSpeed1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMinusSpeed1.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusSpeed1.TabIndex = 0;
            this.buttonMinusSpeed1.Text = "-";
            this.buttonMinusSpeed1.UseVisualStyleBackColor = true;
            this.buttonMinusSpeed1.Click += new System.EventHandler(this.buttonMinusSpeed1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(235, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 255);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Яркость";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxHeat2);
            this.groupBox4.Controls.Add(this.labelBr2);
            this.groupBox4.Controls.Add(this.buttonPlusBright2);
            this.groupBox4.Controls.Add(this.buttonMinusBright2);
            this.groupBox4.Location = new System.Drawing.Point(14, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 106);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сетка 2";
            // 
            // checkBoxHeat2
            // 
            this.checkBoxHeat2.AutoSize = true;
            this.checkBoxHeat2.Enabled = false;
            this.checkBoxHeat2.Location = new System.Drawing.Point(15, 77);
            this.checkBoxHeat2.Name = "checkBoxHeat2";
            this.checkBoxHeat2.Size = new System.Drawing.Size(130, 17);
            this.checkBoxHeat2.TabIndex = 4;
            this.checkBoxHeat2.Text = "Включить подсветку";
            this.checkBoxHeat2.UseVisualStyleBackColor = true;
            this.checkBoxHeat2.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // labelBr2
            // 
            this.labelBr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBr2.Location = new System.Drawing.Point(119, 19);
            this.labelBr2.Name = "labelBr2";
            this.labelBr2.Size = new System.Drawing.Size(46, 41);
            this.labelBr2.TabIndex = 3;
            this.labelBr2.Text = "0";
            this.labelBr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusBright2
            // 
            this.buttonPlusBright2.Enabled = false;
            this.buttonPlusBright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusBright2.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusBright2.Name = "buttonPlusBright2";
            this.buttonPlusBright2.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusBright2.TabIndex = 0;
            this.buttonPlusBright2.Text = "+";
            this.buttonPlusBright2.UseVisualStyleBackColor = true;
            this.buttonPlusBright2.Click += new System.EventHandler(this.buttonPlusBright2_Click);
            // 
            // buttonMinusBright2
            // 
            this.buttonMinusBright2.Enabled = false;
            this.buttonMinusBright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusBright2.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusBright2.Name = "buttonMinusBright2";
            this.buttonMinusBright2.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusBright2.TabIndex = 0;
            this.buttonMinusBright2.Text = "-";
            this.buttonMinusBright2.UseVisualStyleBackColor = true;
            this.buttonMinusBright2.Click += new System.EventHandler(this.buttonMinusBright2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxHeat1);
            this.groupBox6.Controls.Add(this.labelBr1);
            this.groupBox6.Controls.Add(this.buttonPlusBright1);
            this.groupBox6.Controls.Add(this.buttonMinusBright1);
            this.groupBox6.Location = new System.Drawing.Point(14, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 106);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сетка 1";
            // 
            // checkBoxHeat1
            // 
            this.checkBoxHeat1.AutoSize = true;
            this.checkBoxHeat1.Enabled = false;
            this.checkBoxHeat1.Location = new System.Drawing.Point(15, 77);
            this.checkBoxHeat1.Name = "checkBoxHeat1";
            this.checkBoxHeat1.Size = new System.Drawing.Size(130, 17);
            this.checkBoxHeat1.TabIndex = 4;
            this.checkBoxHeat1.Text = "Включить подсветку";
            this.checkBoxHeat1.UseVisualStyleBackColor = true;
            this.checkBoxHeat1.CheckedChanged += new System.EventHandler(this.checkBoxEvents);
            // 
            // labelBr1
            // 
            this.labelBr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBr1.Location = new System.Drawing.Point(119, 19);
            this.labelBr1.Name = "labelBr1";
            this.labelBr1.Size = new System.Drawing.Size(46, 41);
            this.labelBr1.TabIndex = 3;
            this.labelBr1.Text = "0";
            this.labelBr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusBright1
            // 
            this.buttonPlusBright1.Enabled = false;
            this.buttonPlusBright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusBright1.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusBright1.Name = "buttonPlusBright1";
            this.buttonPlusBright1.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusBright1.TabIndex = 0;
            this.buttonPlusBright1.Text = "+";
            this.buttonPlusBright1.UseVisualStyleBackColor = true;
            this.buttonPlusBright1.Click += new System.EventHandler(this.buttonPlusBright1_Click);
            // 
            // buttonMinusBright1
            // 
            this.buttonMinusBright1.Enabled = false;
            this.buttonMinusBright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusBright1.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusBright1.Name = "buttonMinusBright1";
            this.buttonMinusBright1.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusBright1.TabIndex = 0;
            this.buttonMinusBright1.Text = "-\r\n";
            this.buttonMinusBright1.UseVisualStyleBackColor = true;
            this.buttonMinusBright1.Click += new System.EventHandler(this.buttonMinusBright1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "7872.11.00.400";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxCollimators;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonPlusSpeed2;
        private System.Windows.Forms.Button buttonMinusSpeed2;
        private System.Windows.Forms.Label labelSpeed2;
        private System.Windows.Forms.Label labelBright1;
        private System.Windows.Forms.Button buttonPlusSpeed1;
        private System.Windows.Forms.Button buttonMinusSpeed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBr2;
        private System.Windows.Forms.Button buttonPlusBright2;
        private System.Windows.Forms.Button buttonMinusBright2;
        private System.Windows.Forms.GroupBox groupBox6;
        //private System.Windows.Forms.Label labelBright1;
        private System.Windows.Forms.Button buttonPlusBright1;
        private System.Windows.Forms.Button buttonMinusBright1;
        private System.Windows.Forms.Label labelSpeed1;
        private System.Windows.Forms.Label labelBr1;
        public System.Windows.Forms.CheckBox checkBoxMotor2;
        public System.Windows.Forms.CheckBox checkBoxMotor1;
        public System.Windows.Forms.CheckBox checkBoxHeat2;
        public System.Windows.Forms.CheckBox checkBoxHeat1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelCom;
    }
}

