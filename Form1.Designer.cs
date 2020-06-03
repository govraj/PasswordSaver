namespace PasswordSaver
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
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblCPass = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.linkGetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(57, 57);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(83, 13);
            this.lblWeb.TabIndex = 0;
            this.lblWeb.Text = "Website Name :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(81, 96);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password :";
            // 
            // lblCPass
            // 
            this.lblCPass.AutoSize = true;
            this.lblCPass.Location = new System.Drawing.Point(43, 135);
            this.lblCPass.Name = "lblCPass";
            this.lblCPass.Size = new System.Drawing.Size(97, 13);
            this.lblCPass.TabIndex = 2;
            this.lblCPass.Text = "Confirm Password :";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(182, 57);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(140, 20);
            this.txtWeb.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(182, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(130, 20);
            this.txtPass.TabIndex = 4;
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(182, 132);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.PasswordChar = '*';
            this.txtCPass.Size = new System.Drawing.Size(130, 20);
            this.txtCPass.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(182, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 34);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desktop Application To Save Password in Database";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(43, 257);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error: ";
            // 
            // linkGetPassword
            // 
            this.linkGetPassword.AutoSize = true;
            this.linkGetPassword.Location = new System.Drawing.Point(227, 338);
            this.linkGetPassword.Name = "linkGetPassword";
            this.linkGetPassword.Size = new System.Drawing.Size(73, 13);
            this.linkGetPassword.TabIndex = 9;
            this.linkGetPassword.TabStop = true;
            this.linkGetPassword.Text = "Get Password";
            this.linkGetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGetPassword_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 463);
            this.Controls.Add(this.linkGetPassword);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblCPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblCPass;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel linkGetPassword;
    }
}

