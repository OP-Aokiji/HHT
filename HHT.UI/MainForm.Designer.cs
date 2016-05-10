namespace HHT.UI
{
    partial class MainForm
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGrabHeight = new System.Windows.Forms.Label();
            this.lblHoldNo = new System.Windows.Forms.Label();
            this.lblQC = new System.Windows.Forms.Label();
            this.lblVessel = new System.Windows.Forms.Label();
            this.lblBargeName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGrabList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(89, 185);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(135, 20);
            // 
            // lblGrabHeight
            // 
            this.lblGrabHeight.Location = new System.Drawing.Point(89, 150);
            this.lblGrabHeight.Name = "lblGrabHeight";
            this.lblGrabHeight.Size = new System.Drawing.Size(135, 20);
            // 
            // lblHoldNo
            // 
            this.lblHoldNo.Location = new System.Drawing.Point(89, 115);
            this.lblHoldNo.Name = "lblHoldNo";
            this.lblHoldNo.Size = new System.Drawing.Size(135, 20);
            // 
            // lblQC
            // 
            this.lblQC.Location = new System.Drawing.Point(89, 80);
            this.lblQC.Name = "lblQC";
            this.lblQC.Size = new System.Drawing.Size(135, 20);
            // 
            // lblVessel
            // 
            this.lblVessel.Location = new System.Drawing.Point(89, 45);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(135, 20);
            // 
            // lblBargeName
            // 
            this.lblBargeName.Location = new System.Drawing.Point(89, 10);
            this.lblBargeName.Name = "lblBargeName";
            this.lblBargeName.Size = new System.Drawing.Size(135, 20);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.Text = "Weight:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.Text = "Hold No:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.Text = "QC:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.Text = "Vessel:";
            // 
            // btnGrabList
            // 
            this.btnGrabList.Location = new System.Drawing.Point(134, 218);
            this.btnGrabList.Name = "btnGrabList";
            this.btnGrabList.Size = new System.Drawing.Size(72, 20);
            this.btnGrabList.TabIndex = 24;
            this.btnGrabList.Text = "Grab List";
            this.btnGrabList.Click += new System.EventHandler(this.btnGrabList_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 0);
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "label4";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.Text = "Barge Name:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.Text = "Grab Height:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblGrabHeight);
            this.Controls.Add(this.lblHoldNo);
            this.Controls.Add(this.lblQC);
            this.Controls.Add(this.lblVessel);
            this.Controls.Add(this.lblBargeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGrabList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblGrabHeight;
        private System.Windows.Forms.Label lblHoldNo;
        private System.Windows.Forms.Label lblQC;
        private System.Windows.Forms.Label lblVessel;
        private System.Windows.Forms.Label lblBargeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGrabList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}
