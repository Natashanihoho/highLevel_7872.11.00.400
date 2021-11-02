
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
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxCollimators = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(305, 190);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(99, 45);
            this.buttonPower.TabIndex = 0;
            this.buttonPower.Text = "Старт / Стоп";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(206, 190);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 45);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxCollimators
            // 
            this.comboBoxCollimators.FormattingEnabled = true;
            this.comboBoxCollimators.Location = new System.Drawing.Point(51, 214);
            this.comboBoxCollimators.Name = "comboBoxCollimators";
            this.comboBoxCollimators.Size = new System.Drawing.Size(104, 21);
            this.comboBoxCollimators.TabIndex = 1;
            this.comboBoxCollimators.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(72, 190);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Коллиматор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxCollimators);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonPower);
            this.Name = "Form1";
            this.Text = "7872.11.00.400";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxCollimators;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}

