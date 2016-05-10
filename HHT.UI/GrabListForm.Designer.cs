namespace HHT.UI
{
    partial class GrabListForm
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBot = new System.Windows.Forms.Panel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.lblBargeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPage = new HHT.Framework.UserControls.MyComboBox();
            this.grdGrab = new System.Windows.Forms.DataGrid();
            this.pnTop.SuspendLayout();
            this.pnBot.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblBargeName);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(238, 39);
            // 
            // pnBot
            // 
            this.pnBot.Controls.Add(this.cmbPage);
            this.pnBot.Controls.Add(this.button2);
            this.pnBot.Controls.Add(this.button1);
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBot.Location = new System.Drawing.Point(0, 226);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(238, 49);
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.grdGrab);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 39);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(238, 187);
            // 
            // lblBargeName
            // 
            this.lblBargeName.Location = new System.Drawing.Point(95, 10);
            this.lblBargeName.Name = "lblBargeName";
            this.lblBargeName.Size = new System.Drawing.Size(131, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.Text = "Barge Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Prev";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            // 
            // cmbPage
            // 
            this.cmbPage.isBusinessItemName = "";
            this.cmbPage.isMandatory = false;
            this.cmbPage.Location = new System.Drawing.Point(78, 11);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(75, 23);
            this.cmbPage.TabIndex = 5;
            // 
            // grdGrab
            // 
            this.grdGrab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdGrab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGrab.Location = new System.Drawing.Point(0, 0);
            this.grdGrab.Name = "grdGrab";
            this.grdGrab.Size = new System.Drawing.Size(238, 187);
            this.grdGrab.TabIndex = 0;
            // 
            // GrabListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnBot);
            this.Controls.Add(this.pnTop);
            this.Name = "GrabListForm";
            this.Text = "Grab List";
            this.pnTop.ResumeLayout(false);
            this.pnBot.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBot;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label lblBargeName;
        private System.Windows.Forms.Label label1;
        private HHT.Framework.UserControls.MyComboBox cmbPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGrid grdGrab;
    }
}
