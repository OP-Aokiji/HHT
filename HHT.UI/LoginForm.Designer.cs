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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new HHT.Framework.UserControls.MyTextBox(this.components);
            this.txtPassword = new HHT.Framework.UserControls.MyTextBox(this.components);
            this.txxtBargeName = new HHT.Framework.UserControls.MyTextBox(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbQC = new HHT.Framework.UserControls.MyComboBox();
            this.cmbHoldNo = new HHT.Framework.UserControls.MyComboBox();
            this.cmbVessel = new HHT.Framework.UserControls.MyComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "QC";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.Text = "Hold No";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.Text = "Barge Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "Vessel";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.isCharacterType = HHT.Framework.UserControls.MyTextBox.CharacterList.Default;
            this.txtUserName.Location = new System.Drawing.Point(80, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 23);
            this.txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.isCharacterType = HHT.Framework.UserControls.MyTextBox.CharacterList.Default;
            this.txtPassword.Location = new System.Drawing.Point(80, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.TabIndex = 13;
            // 
            // txxtBargeName
            // 
            this.txxtBargeName.isCharacterType = HHT.Framework.UserControls.MyTextBox.CharacterList.Default;
            this.txxtBargeName.Location = new System.Drawing.Point(80, 115);
            this.txxtBargeName.Name = "txxtBargeName";
            this.txxtBargeName.Size = new System.Drawing.Size(140, 23);
            this.txxtBargeName.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 20);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 20);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(80, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            // 
            // cmbQC
            // 
            this.cmbQC.isBusinessItemName = "";
            this.cmbQC.isMandatory = false;
            this.cmbQC.Location = new System.Drawing.Point(80, 209);
            this.cmbQC.Name = "cmbQC";
            this.cmbQC.Size = new System.Drawing.Size(140, 23);
            this.cmbQC.TabIndex = 19;
            // 
            // cmbHoldNo
            // 
            this.cmbHoldNo.isBusinessItemName = "";
            this.cmbHoldNo.isMandatory = false;
            this.cmbHoldNo.Location = new System.Drawing.Point(80, 174);
            this.cmbHoldNo.Name = "cmbHoldNo";
            this.cmbHoldNo.Size = new System.Drawing.Size(94, 23);
            this.cmbHoldNo.TabIndex = 20;
            // 
            // cmbVessel
            // 
            this.cmbVessel.isBusinessItemName = "";
            this.cmbVessel.isMandatory = false;
            this.cmbVessel.Location = new System.Drawing.Point(80, 77);
            this.cmbVessel.Name = "cmbVessel";
            this.cmbVessel.Size = new System.Drawing.Size(140, 23);
            this.cmbVessel.TabIndex = 21;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.cmbVessel);
            this.Controls.Add(this.cmbHoldNo);
            this.Controls.Add(this.cmbQC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txxtBargeName);
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

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HHT.Framework.UserControls.MyTextBox txtUserName;
        private HHT.Framework.UserControls.MyTextBox txtPassword;
        private HHT.Framework.UserControls.MyTextBox txxtBargeName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearch;
        private HHT.Framework.UserControls.MyComboBox cmbQC;
        private HHT.Framework.UserControls.MyComboBox cmbHoldNo;
        private HHT.Framework.UserControls.MyComboBox cmbVessel;
    }
}
