
namespace FinalProject
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxUsernameTxtbox = new System.Windows.Forms.TextBox();
            this.uxPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(13, 13);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.uxUsernameLabel.TabIndex = 2;
            this.uxUsernameLabel.Text = "Username:";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(16, 53);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.uxPasswordLabel.TabIndex = 3;
            this.uxPasswordLabel.Text = "Password:";
            // 
            // uxUsernameTxtbox
            // 
            this.uxUsernameTxtbox.Location = new System.Drawing.Point(96, 13);
            this.uxUsernameTxtbox.Name = "uxUsernameTxtbox";
            this.uxUsernameTxtbox.Size = new System.Drawing.Size(100, 22);
            this.uxUsernameTxtbox.TabIndex = 4;
            // 
            // uxPasswordTxtbox
            // 
            this.uxPasswordTxtbox.Location = new System.Drawing.Point(96, 47);
            this.uxPasswordTxtbox.Name = "uxPasswordTxtbox";
            this.uxPasswordTxtbox.Size = new System.Drawing.Size(100, 22);
            this.uxPasswordTxtbox.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxPasswordTxtbox);
            this.Controls.Add(this.uxUsernameTxtbox);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.TextBox uxUsernameTxtbox;
        private System.Windows.Forms.TextBox uxPasswordTxtbox;
    }
}