
namespace FinalProject
{
    partial class DailyLogForm
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
            this.uxLogBackBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLogBackBtn
            // 
            this.uxLogBackBtn.Location = new System.Drawing.Point(535, 284);
            this.uxLogBackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLogBackBtn.Name = "uxLogBackBtn";
            this.uxLogBackBtn.Size = new System.Drawing.Size(56, 72);
            this.uxLogBackBtn.TabIndex = 0;
            this.uxLogBackBtn.Text = "Back";
            this.uxLogBackBtn.UseVisualStyleBackColor = true;
            this.uxLogBackBtn.Click += new System.EventHandler(this.uxLogBackBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 269);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DailyLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxLogBackBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DailyLogForm";
            this.Text = "DailyLogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxLogBackBtn;
        private System.Windows.Forms.Button button2;
    }
}