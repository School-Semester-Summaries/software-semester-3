namespace Reverse_Hangman_Online_Backend
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
            this.BTN_GET = new System.Windows.Forms.Button();
            this.BTN_POST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_GET
            // 
            this.BTN_GET.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BTN_GET.Location = new System.Drawing.Point(12, 12);
            this.BTN_GET.Name = "BTN_GET";
            this.BTN_GET.Size = new System.Drawing.Size(829, 213);
            this.BTN_GET.TabIndex = 0;
            this.BTN_GET.Text = "API - GET";
            this.BTN_GET.UseVisualStyleBackColor = true;
            this.BTN_GET.Click += new System.EventHandler(this.BTN_GET_Click);
            // 
            // BTN_POST
            // 
            this.BTN_POST.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BTN_POST.Location = new System.Drawing.Point(12, 231);
            this.BTN_POST.Name = "BTN_POST";
            this.BTN_POST.Size = new System.Drawing.Size(829, 213);
            this.BTN_POST.TabIndex = 1;
            this.BTN_POST.Text = "API - POST";
            this.BTN_POST.UseVisualStyleBackColor = true;
            this.BTN_POST.Click += new System.EventHandler(this.BTN_POST_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.BTN_POST);
            this.Controls.Add(this.BTN_GET);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN_GET;
        private Button BTN_POST;
    }
}