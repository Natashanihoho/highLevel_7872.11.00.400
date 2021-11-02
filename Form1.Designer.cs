
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.comboBoxCollimators = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlusSpeed2 = new System.Windows.Forms.Button();
            this.buttonMinusSpeed2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlusSpeed1 = new System.Windows.Forms.Button();
            this.buttonMinusSpeed1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPlusBright2 = new System.Windows.Forms.Button();
            this.buttonMinusBright2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(12, 280);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(202, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт ";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(235, 280);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(202, 45);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // comboBoxCollimators
            // 
            this.comboBoxCollimators.FormattingEnabled = true;
            this.comboBoxCollimators.Location = new System.Drawing.Point(310, 38);
            this.comboBoxCollimators.Name = "comboBoxCollimators";
            this.comboBoxCollimators.Size = new System.Drawing.Size(110, 21);
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
            this.groupBox1.Controls.Add(this.buttonInit);
            this.groupBox1.Controls.Add(this.comboBoxCollimators);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonInit
            // 
            this.buttonInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInit.Location = new System.Drawing.Point(12, 12);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(153, 47);
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
            this.groupBox2.Size = new System.Drawing.Size(202, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скорость";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.buttonPlusSpeed2);
            this.groupBox7.Controls.Add(this.buttonMinusSpeed2);
            this.groupBox7.Location = new System.Drawing.Point(14, 102);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(171, 72);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Сетка 2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusSpeed2
            // 
            this.buttonPlusSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusSpeed2.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusSpeed2.Name = "buttonPlusSpeed2";
            this.buttonPlusSpeed2.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusSpeed2.TabIndex = 0;
            this.buttonPlusSpeed2.Text = "+";
            this.buttonPlusSpeed2.UseVisualStyleBackColor = true;
            // 
            // buttonMinusSpeed2
            // 
            this.buttonMinusSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusSpeed2.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusSpeed2.Name = "buttonMinusSpeed2";
            this.buttonMinusSpeed2.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusSpeed2.TabIndex = 0;
            this.buttonMinusSpeed2.Text = "-";
            this.buttonMinusSpeed2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.buttonPlusSpeed1);
            this.groupBox5.Controls.Add(this.buttonMinusSpeed1);
            this.groupBox5.Location = new System.Drawing.Point(14, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 72);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сетка 1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusSpeed1
            // 
            this.buttonPlusSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusSpeed1.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusSpeed1.Name = "buttonPlusSpeed1";
            this.buttonPlusSpeed1.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusSpeed1.TabIndex = 0;
            this.buttonPlusSpeed1.Text = "+";
            this.buttonPlusSpeed1.UseVisualStyleBackColor = true;
            // 
            // buttonMinusSpeed1
            // 
            this.buttonMinusSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusSpeed1.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusSpeed1.Name = "buttonMinusSpeed1";
            this.buttonMinusSpeed1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMinusSpeed1.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusSpeed1.TabIndex = 0;
            this.buttonMinusSpeed1.Text = "-";
            this.buttonMinusSpeed1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(235, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 186);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Яркость";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonPlusBright2);
            this.groupBox4.Controls.Add(this.buttonMinusBright2);
            this.groupBox4.Location = new System.Drawing.Point(14, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сетка 2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusBright2
            // 
            this.buttonPlusBright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusBright2.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusBright2.Name = "buttonPlusBright2";
            this.buttonPlusBright2.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusBright2.TabIndex = 0;
            this.buttonPlusBright2.Text = "+";
            this.buttonPlusBright2.UseVisualStyleBackColor = true;
            // 
            // buttonMinusBright2
            // 
            this.buttonMinusBright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusBright2.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusBright2.Name = "buttonMinusBright2";
            this.buttonMinusBright2.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusBright2.TabIndex = 0;
            this.buttonMinusBright2.Text = "-";
            this.buttonMinusBright2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.buttonPlusBright1);
            this.groupBox6.Controls.Add(this.buttonMinusBright1);
            this.groupBox6.Location = new System.Drawing.Point(14, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 72);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сетка 1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(119, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusBright1
            // 
            this.buttonPlusBright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusBright1.Location = new System.Drawing.Point(67, 19);
            this.buttonPlusBright1.Name = "buttonPlusBright1";
            this.buttonPlusBright1.Size = new System.Drawing.Size(46, 41);
            this.buttonPlusBright1.TabIndex = 0;
            this.buttonPlusBright1.Text = "+";
            this.buttonPlusBright1.UseVisualStyleBackColor = true;
            // 
            // buttonMinusBright1
            // 
            this.buttonMinusBright1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusBright1.Location = new System.Drawing.Point(15, 19);
            this.buttonMinusBright1.Name = "buttonMinusBright1";
            this.buttonMinusBright1.Size = new System.Drawing.Size(46, 41);
            this.buttonMinusBright1.TabIndex = 0;
            this.buttonMinusBright1.Text = "-\r\n";
            this.buttonMinusBright1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "7872.11.00.400";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxCollimators;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonPlusSpeed2;
        private System.Windows.Forms.Button buttonMinusSpeed2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlusSpeed1;
        private System.Windows.Forms.Button buttonMinusSpeed1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPlusBright2;
        private System.Windows.Forms.Button buttonMinusBright2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPlusBright1;
        private System.Windows.Forms.Button buttonMinusBright1;
    }
}

