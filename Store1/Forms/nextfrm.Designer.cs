namespace Store1
{
    partial class nextfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nextfrm));
            this.mylabel = new System.Windows.Forms.Label();
            this.nextfrmgrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.Logoutbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.Exitbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.nextfrmgrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mylabel
            // 
            this.mylabel.AutoSize = true;
            this.mylabel.Location = new System.Drawing.Point(102, 24);
            this.mylabel.Name = "mylabel";
            this.mylabel.Size = new System.Drawing.Size(35, 13);
            this.mylabel.TabIndex = 0;
            this.mylabel.Text = "label1";
            // 
            // nextfrmgrid
            // 
            this.nextfrmgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nextfrmgrid.Location = new System.Drawing.Point(756, 635);
            this.nextfrmgrid.Name = "nextfrmgrid";
            this.nextfrmgrid.Size = new System.Drawing.Size(582, 82);
            this.nextfrmgrid.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.AddEmployeeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileButton
            // 
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logoutbutton,
            this.Exitbutton});
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(38, 22);
            this.FileButton.Text = "File";
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(152, 22);
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(152, 22);
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddEmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployeeButton.Image")));
            this.AddEmployeeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(101, 22);
            this.AddEmployeeButton.Text = "Employee Details";
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // nextfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.nextfrmgrid);
            this.Controls.Add(this.mylabel);
            this.MaximizeBox = false;
            this.Name = "nextfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nextfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.nextfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nextfrmgrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mylabel;
        private System.Windows.Forms.DataGridView nextfrmgrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem Logoutbutton;
        private System.Windows.Forms.ToolStripMenuItem Exitbutton;
        private System.Windows.Forms.ToolStripButton AddEmployeeButton;
    }
}