namespace HHT.UI
{
    partial class GrabListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBargeName = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.grdGrabList = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.Text = "Barge Name:";
            // 
            // lblBargeName
            // 
            this.lblBargeName.Location = new System.Drawing.Point(95, 10);
            this.lblBargeName.Name = "lblBargeName";
            this.lblBargeName.Size = new System.Drawing.Size(131, 20);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblBargeName);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(238, 43);
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.grdGrabList);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 43);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(238, 232);
            // 
            // grdGrabList
            // 
            this.grdGrabList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdGrabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGrabList.Location = new System.Drawing.Point(0, 0);
            this.grdGrabList.Name = "grdGrabList";
            this.grdGrabList.Size = new System.Drawing.Size(238, 232);
            this.grdGrabList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 47);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prev";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(73, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // GrabListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Menu = this.mainMenu1;
            this.Name = "GrabListForm";
            this.Text = "Grab List";
            this.pnTop.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBargeName;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.DataGrid grdGrabList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}