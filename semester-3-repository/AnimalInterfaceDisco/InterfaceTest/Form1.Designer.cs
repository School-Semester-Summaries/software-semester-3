namespace InterfaceTest
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
            this.BTN_Meow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Meow
            // 
            this.BTN_Meow.Location = new System.Drawing.Point(12, 12);
            this.BTN_Meow.Name = "BTN_Meow";
            this.BTN_Meow.Size = new System.Drawing.Size(94, 29);
            this.BTN_Meow.TabIndex = 0;
            this.BTN_Meow.Text = "cat meow";
            this.BTN_Meow.UseVisualStyleBackColor = true;
            this.BTN_Meow.Click += new System.EventHandler(this.BTN_Meow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Meow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN_Meow;
    }
}