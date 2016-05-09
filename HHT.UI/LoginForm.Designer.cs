namespace HHT.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBargeName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbQC = new System.Windows.Forms.ComboBox();
            this.cmbHoldNo = new System.Windows.Forms.ComboBox();
            this.cmbVessel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "Vessel";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.Text = "Barge Name";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.Text = "Hold No";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "QC";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(89, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.TabIndex = 11;
            // 
            // txtBargeName
            // 
            this.txtBargeName.Location = new System.Drawing.Point(89, 112);
            this.txtBargeName.Name = "txtBargeName";
            this.txtBargeName.Size = new System.Drawing.Size(140, 23);
            this.txtBargeName.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(89, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(11, 236);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 20);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(157, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 20);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            // 
            // cmbQC
            // 
            this.cmbQC.Location = new System.Drawing.Point(89, 206);
            this.cmbQC.Name = "cmbQC";
            this.cmbQC.Size = new System.Drawing.Size(140, 23);
            this.cmbQC.TabIndex = 16;
            // 
            // cmbHoldNo
            // 
            this.cmbHoldNo.Location = new System.Drawing.Point(89, 171);
            this.cmbHoldNo.Name = "cmbHoldNo";
            this.cmbHoldNo.Size = new System.Drawing.Size(79, 23);
            this.cmbHoldNo.TabIndex = 17;
            // 
            // cmbVessel
            // 
            this.cmbVessel.Location = new System.Drawing.Point(89, 73);
            this.cmbVessel.Name = "cmbVessel";
            this.cmbVessel.Size = new System.Drawing.Size(100, 23);
            this.cmbVessel.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.cmbVessel);
            this.Controls.Add(this.cmbHoldNo);
            this.Controls.Add(this.cmbQC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBargeName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBargeName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbQC;
        private System.Windows.Forms.ComboBox cmbHoldNo;
        private System.Windows.Forms.ComboBox cmbVessel;
    }
}