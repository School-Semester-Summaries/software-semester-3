
namespace Spambot
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
            this.TMR_Inputs = new System.Windows.Forms.Timer(this.components);
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Digit1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Digit2 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Digit3 = new System.Windows.Forms.NumericUpDown();
            this.NUD_Digit4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit4)).BeginInit();
            this.SuspendLayout();
            // 
            // TMR_Inputs
            // 
            this.TMR_Inputs.Interval = 1300;
            this.TMR_Inputs.Tick += new System.EventHandler(this.TMR_Inputs_Tick);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(12, 18);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(57, 24);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(75, 18);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(57, 24);
            this.BTN_Stop.TabIndex = 1;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Number";
            // 
            // NUD_Digit1
            // 
            this.NUD_Digit1.Location = new System.Drawing.Point(12, 117);
            this.NUD_Digit1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_Digit1.Name = "NUD_Digit1";
            this.NUD_Digit1.Size = new System.Drawing.Size(41, 22);
            this.NUD_Digit1.TabIndex = 4;
            // 
            // NUD_Digit2
            // 
            this.NUD_Digit2.Location = new System.Drawing.Point(59, 117);
            this.NUD_Digit2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_Digit2.Name = "NUD_Digit2";
            this.NUD_Digit2.Size = new System.Drawing.Size(41, 22);
            this.NUD_Digit2.TabIndex = 5;
            // 
            // NUD_Digit3
            // 
            this.NUD_Digit3.Location = new System.Drawing.Point(106, 117);
            this.NUD_Digit3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_Digit3.Name = "NUD_Digit3";
            this.NUD_Digit3.Size = new System.Drawing.Size(41, 22);
            this.NUD_Digit3.TabIndex = 6;
            // 
            // NUD_Digit4
            // 
            this.NUD_Digit4.Location = new System.Drawing.Point(153, 117);
            this.NUD_Digit4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_Digit4.Name = "NUD_Digit4";
            this.NUD_Digit4.Size = new System.Drawing.Size(41, 22);
            this.NUD_Digit4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 151);
            this.Controls.Add(this.NUD_Digit4);
            this.Controls.Add(this.NUD_Digit3);
            this.Controls.Add(this.NUD_Digit2);
            this.Controls.Add(this.NUD_Digit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Stop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Digit4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TMR_Inputs;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Digit1;
        private System.Windows.Forms.NumericUpDown NUD_Digit2;
        private System.Windows.Forms.NumericUpDown NUD_Digit3;
        private System.Windows.Forms.NumericUpDown NUD_Digit4;
    }
}

