namespace PasswordSaver
{
    partial class GetPassword
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetPass = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblpass1 = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.link_SavePass = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInfo.Location = new System.Drawing.Point(56, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(314, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Check Password by Selecting Website";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(54, 91);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(46, 13);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnGetPass
            // 
            this.btnGetPass.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPass.ForeColor = System.Drawing.Color.Blue;
            this.btnGetPass.Location = new System.Drawing.Point(295, 73);
            this.btnGetPass.Name = "btnGetPass";
            this.btnGetPass.Size = new System.Drawing.Size(75, 38);
            this.btnGetPass.TabIndex = 3;
            this.btnGetPass.Text = "Get Password";
            this.btnGetPass.UseVisualStyleBackColor = false;
            this.btnGetPass.Click += new System.EventHandler(this.btnGetPass_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(54, 165);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 4;
            // 
            // lblpass1
            // 
            this.lblpass1.AutoSize = true;
            this.lblpass1.Location = new System.Drawing.Point(54, 221);
            this.lblpass1.Name = "lblpass1";
            this.lblpass1.Size = new System.Drawing.Size(62, 13);
            this.lblpass1.TabIndex = 5;
            this.lblpass1.Text = "Password : ";
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(131, 221);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(0, 13);
            this.lblPass2.TabIndex = 6;
            // 
            // link_SavePass
            // 
            this.link_SavePass.AutoSize = true;
            this.link_SavePass.Location = new System.Drawing.Point(196, 353);
            this.link_SavePass.Name = "link_SavePass";
            this.link_SavePass.Size = new System.Drawing.Size(81, 13);
            this.link_SavePass.TabIndex = 7;
            this.link_SavePass.TabStop = true;
            this.link_SavePass.Text = "Save Password";
            this.link_SavePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SavePass_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(350, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 463);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.link_SavePass);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.lblpass1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnGetPass);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblInfo);
            this.Name = "GetPassword";
            this.Text = "GetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetPass;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblpass1;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.LinkLabel link_SavePass;
        private System.Windows.Forms.Button btnDelete;
    }
}