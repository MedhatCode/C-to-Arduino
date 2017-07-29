namespace C_Sharp_to_Arduino
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
            this.components = new System.ComponentModel.Container();
            this.led = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwm = new System.Windows.Forms.TrackBar();
            this.value = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pwm)).BeginInit();
            this.SuspendLayout();
            // 
            // led
            // 
            this.led.Location = new System.Drawing.Point(13, 142);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(75, 23);
            this.led.TabIndex = 0;
            this.led.Text = "Toggle LED";
            this.led.UseVisualStyleBackColor = true;
            this.led.Click += new System.EventHandler(this.led_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "255";
            // 
            // pwm
            // 
            this.pwm.Location = new System.Drawing.Point(2, 30);
            this.pwm.Maximum = 255;
            this.pwm.Name = "pwm";
            this.pwm.Size = new System.Drawing.Size(284, 45);
            this.pwm.TabIndex = 3;
            this.pwm.TickFrequency = 15;
            this.pwm.Scroll += new System.EventHandler(this.pwm_Scroll);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(123, 78);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(33, 13);
            this.value.TabIndex = 4;
            this.value.Text = "value";
            this.value.Click += new System.EventHandler(this.label3_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.value);
            this.Controls.Add(this.pwm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.led);
            this.Name = "Form1";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.pwm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button led;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar pwm;
        private System.Windows.Forms.Label value;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

