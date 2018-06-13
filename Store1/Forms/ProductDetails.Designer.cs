namespace Storeapp.Forms
{
    partial class ProductDetails
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
            this.buttonProback = new System.Windows.Forms.Button();
            this.ProductSettings = new System.Windows.Forms.TabControl();
            this.Proadd = new System.Windows.Forms.TabPage();
            this.ProaddPpieces = new System.Windows.Forms.TextBox();
            this.buttonProaddSave = new System.Windows.Forms.Button();
            this.buttonProaddCancel = new System.Windows.Forms.Button();
            this.ProaddPrate = new System.Windows.Forms.TextBox();
            this.ProaddPname = new System.Windows.Forms.TextBox();
            this.ProaddPcode = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.Proedit = new System.Windows.Forms.TabPage();
            this.Prodelete = new System.Windows.Forms.TabPage();
            this.buttonProdeleteDelete = new System.Windows.Forms.Button();
            this.buttonProdeleteCancel = new System.Windows.Forms.Button();
            this.hh = new System.Windows.Forms.Label();
            this.ProPcodetoDelete = new System.Windows.Forms.TextBox();
            this.Prosearch = new System.Windows.Forms.TabPage();
            this.buttonProsearchSearch = new System.Windows.Forms.Button();
            this.buttonProsearchCancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProeditPpieces = new System.Windows.Forms.TextBox();
            this.buttonProeditSave = new System.Windows.Forms.Button();
            this.buttonProeditCancel = new System.Windows.Forms.Button();
            this.ProeditPrate = new System.Windows.Forms.TextBox();
            this.ProeditPname = new System.Windows.Forms.TextBox();
            this.ProeditPcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProPnametoDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProsearchPname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProsearchPcode = new System.Windows.Forms.TextBox();
            this.ProductSettings.SuspendLayout();
            this.Proadd.SuspendLayout();
            this.Proedit.SuspendLayout();
            this.Prodelete.SuspendLayout();
            this.Prosearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProback
            // 
            this.buttonProback.Location = new System.Drawing.Point(786, 42);
            this.buttonProback.Name = "buttonProback";
            this.buttonProback.Size = new System.Drawing.Size(75, 23);
            this.buttonProback.TabIndex = 72;
            this.buttonProback.Text = "Back";
            this.buttonProback.UseVisualStyleBackColor = true;
            // 
            // ProductSettings
            // 
            this.ProductSettings.Controls.Add(this.Proadd);
            this.ProductSettings.Controls.Add(this.Proedit);
            this.ProductSettings.Controls.Add(this.Prodelete);
            this.ProductSettings.Controls.Add(this.Prosearch);
            this.ProductSettings.Location = new System.Drawing.Point(29, 315);
            this.ProductSettings.Name = "ProductSettings";
            this.ProductSettings.SelectedIndex = 0;
            this.ProductSettings.Size = new System.Drawing.Size(869, 478);
            this.ProductSettings.TabIndex = 71;
            this.ProductSettings.SelectedIndexChanged += new System.EventHandler(this.ProductSettings_SelectedIndexChanged);
            // 
            // Proadd
            // 
            this.Proadd.Controls.Add(this.ProaddPpieces);
            this.Proadd.Controls.Add(this.buttonProaddSave);
            this.Proadd.Controls.Add(this.buttonProaddCancel);
            this.Proadd.Controls.Add(this.ProaddPrate);
            this.Proadd.Controls.Add(this.ProaddPname);
            this.Proadd.Controls.Add(this.ProaddPcode);
            this.Proadd.Controls.Add(this.label36);
            this.Proadd.Controls.Add(this.label37);
            this.Proadd.Controls.Add(this.label48);
            this.Proadd.Controls.Add(this.label49);
            this.Proadd.Location = new System.Drawing.Point(4, 22);
            this.Proadd.Name = "Proadd";
            this.Proadd.Padding = new System.Windows.Forms.Padding(3);
            this.Proadd.Size = new System.Drawing.Size(861, 452);
            this.Proadd.TabIndex = 0;
            this.Proadd.Text = "Add";
            this.Proadd.UseVisualStyleBackColor = true;
            // 
            // ProaddPpieces
            // 
            this.ProaddPpieces.Location = new System.Drawing.Point(381, 164);
            this.ProaddPpieces.Name = "ProaddPpieces";
            this.ProaddPpieces.Size = new System.Drawing.Size(203, 20);
            this.ProaddPpieces.TabIndex = 99;
            // 
            // buttonProaddSave
            // 
            this.buttonProaddSave.Location = new System.Drawing.Point(506, 299);
            this.buttonProaddSave.Name = "buttonProaddSave";
            this.buttonProaddSave.Size = new System.Drawing.Size(197, 86);
            this.buttonProaddSave.TabIndex = 97;
            this.buttonProaddSave.Text = "Save";
            this.buttonProaddSave.UseVisualStyleBackColor = true;
            this.buttonProaddSave.Click += new System.EventHandler(this.buttonProaddSave_Click);
            // 
            // buttonProaddCancel
            // 
            this.buttonProaddCancel.Location = new System.Drawing.Point(177, 299);
            this.buttonProaddCancel.Name = "buttonProaddCancel";
            this.buttonProaddCancel.Size = new System.Drawing.Size(195, 76);
            this.buttonProaddCancel.TabIndex = 96;
            this.buttonProaddCancel.Text = "Cancel";
            this.buttonProaddCancel.UseVisualStyleBackColor = true;
            this.buttonProaddCancel.Click += new System.EventHandler(this.buttonProaddCancel_Click);
            // 
            // ProaddPrate
            // 
            this.ProaddPrate.Location = new System.Drawing.Point(381, 208);
            this.ProaddPrate.Name = "ProaddPrate";
            this.ProaddPrate.Size = new System.Drawing.Size(203, 20);
            this.ProaddPrate.TabIndex = 92;
            this.ProaddPrate.TextChanged += new System.EventHandler(this.ProaddPrate_TextChanged);
            // 
            // ProaddPname
            // 
            this.ProaddPname.Location = new System.Drawing.Point(381, 118);
            this.ProaddPname.Name = "ProaddPname";
            this.ProaddPname.Size = new System.Drawing.Size(203, 20);
            this.ProaddPname.TabIndex = 84;
            this.ProaddPname.TextChanged += new System.EventHandler(this.ProaddPname_TextChanged);
            // 
            // ProaddPcode
            // 
            this.ProaddPcode.Location = new System.Drawing.Point(381, 81);
            this.ProaddPcode.Name = "ProaddPcode";
            this.ProaddPcode.Size = new System.Drawing.Size(203, 20);
            this.ProaddPcode.TabIndex = 81;
            this.ProaddPcode.TextChanged += new System.EventHandler(this.ProaddCode_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(199, 199);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 29);
            this.label36.TabIndex = 79;
            this.label36.Text = "Rate :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(150, 155);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(218, 29);
            this.label37.TabIndex = 78;
            this.label37.Text = "Pieces Per Catton :";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(150, 109);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(179, 29);
            this.label48.TabIndex = 67;
            this.label48.Text = "Product Name :";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(150, 72);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(173, 29);
            this.label49.TabIndex = 66;
            this.label49.Text = "Product Code :";
            // 
            // Proedit
            // 
            this.Proedit.Controls.Add(this.ProeditPpieces);
            this.Proedit.Controls.Add(this.buttonProeditSave);
            this.Proedit.Controls.Add(this.buttonProeditCancel);
            this.Proedit.Controls.Add(this.ProeditPrate);
            this.Proedit.Controls.Add(this.ProeditPname);
            this.Proedit.Controls.Add(this.ProeditPcode);
            this.Proedit.Controls.Add(this.label1);
            this.Proedit.Controls.Add(this.label2);
            this.Proedit.Controls.Add(this.label3);
            this.Proedit.Controls.Add(this.label4);
            this.Proedit.Location = new System.Drawing.Point(4, 22);
            this.Proedit.Name = "Proedit";
            this.Proedit.Padding = new System.Windows.Forms.Padding(3);
            this.Proedit.Size = new System.Drawing.Size(861, 452);
            this.Proedit.TabIndex = 1;
            this.Proedit.Text = "Edit";
            this.Proedit.UseVisualStyleBackColor = true;
            // 
            // Prodelete
            // 
            this.Prodelete.Controls.Add(this.label5);
            this.Prodelete.Controls.Add(this.ProPnametoDelete);
            this.Prodelete.Controls.Add(this.buttonProdeleteDelete);
            this.Prodelete.Controls.Add(this.buttonProdeleteCancel);
            this.Prodelete.Controls.Add(this.hh);
            this.Prodelete.Controls.Add(this.ProPcodetoDelete);
            this.Prodelete.Location = new System.Drawing.Point(4, 22);
            this.Prodelete.Name = "Prodelete";
            this.Prodelete.Padding = new System.Windows.Forms.Padding(3);
            this.Prodelete.Size = new System.Drawing.Size(861, 452);
            this.Prodelete.TabIndex = 2;
            this.Prodelete.Text = "Delete";
            this.Prodelete.UseVisualStyleBackColor = true;
            // 
            // buttonProdeleteDelete
            // 
            this.buttonProdeleteDelete.Location = new System.Drawing.Point(458, 298);
            this.buttonProdeleteDelete.Name = "buttonProdeleteDelete";
            this.buttonProdeleteDelete.Size = new System.Drawing.Size(197, 86);
            this.buttonProdeleteDelete.TabIndex = 141;
            this.buttonProdeleteDelete.Text = "Delete";
            this.buttonProdeleteDelete.UseVisualStyleBackColor = true;
            // 
            // buttonProdeleteCancel
            // 
            this.buttonProdeleteCancel.Location = new System.Drawing.Point(130, 308);
            this.buttonProdeleteCancel.Name = "buttonProdeleteCancel";
            this.buttonProdeleteCancel.Size = new System.Drawing.Size(195, 76);
            this.buttonProdeleteCancel.TabIndex = 140;
            this.buttonProdeleteCancel.Text = "Cancel";
            this.buttonProdeleteCancel.UseVisualStyleBackColor = true;
            // 
            // hh
            // 
            this.hh.AutoSize = true;
            this.hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hh.Location = new System.Drawing.Point(106, 118);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(283, 29);
            this.hh.TabIndex = 137;
            this.hh.Text = "Delete By Product Code :";
            // 
            // ProPcodetoDelete
            // 
            this.ProPcodetoDelete.Location = new System.Drawing.Point(419, 127);
            this.ProPcodetoDelete.Name = "ProPcodetoDelete";
            this.ProPcodetoDelete.Size = new System.Drawing.Size(203, 20);
            this.ProPcodetoDelete.TabIndex = 136;
            // 
            // Prosearch
            // 
            this.Prosearch.Controls.Add(this.label6);
            this.Prosearch.Controls.Add(this.ProsearchPname);
            this.Prosearch.Controls.Add(this.label7);
            this.Prosearch.Controls.Add(this.ProsearchPcode);
            this.Prosearch.Controls.Add(this.buttonProsearchSearch);
            this.Prosearch.Controls.Add(this.buttonProsearchCancel);
            this.Prosearch.Location = new System.Drawing.Point(4, 22);
            this.Prosearch.Name = "Prosearch";
            this.Prosearch.Padding = new System.Windows.Forms.Padding(3);
            this.Prosearch.Size = new System.Drawing.Size(861, 452);
            this.Prosearch.TabIndex = 3;
            this.Prosearch.Text = "Search";
            this.Prosearch.UseVisualStyleBackColor = true;
            // 
            // buttonProsearchSearch
            // 
            this.buttonProsearchSearch.Location = new System.Drawing.Point(498, 307);
            this.buttonProsearchSearch.Name = "buttonProsearchSearch";
            this.buttonProsearchSearch.Size = new System.Drawing.Size(197, 86);
            this.buttonProsearchSearch.TabIndex = 169;
            this.buttonProsearchSearch.Text = "Search";
            this.buttonProsearchSearch.UseVisualStyleBackColor = true;
            // 
            // buttonProsearchCancel
            // 
            this.buttonProsearchCancel.Location = new System.Drawing.Point(179, 312);
            this.buttonProsearchCancel.Name = "buttonProsearchCancel";
            this.buttonProsearchCancel.Size = new System.Drawing.Size(195, 76);
            this.buttonProsearchCancel.TabIndex = 168;
            this.buttonProsearchCancel.Text = "Cancel";
            this.buttonProsearchCancel.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(241, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(394, 63);
            this.label17.TabIndex = 70;
            this.label17.Text = "Product Details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "companylogo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 199);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProeditPpieces
            // 
            this.ProeditPpieces.Location = new System.Drawing.Point(385, 162);
            this.ProeditPpieces.Name = "ProeditPpieces";
            this.ProeditPpieces.Size = new System.Drawing.Size(203, 20);
            this.ProeditPpieces.TabIndex = 115;
            // 
            // buttonProeditSave
            // 
            this.buttonProeditSave.Location = new System.Drawing.Point(510, 297);
            this.buttonProeditSave.Name = "buttonProeditSave";
            this.buttonProeditSave.Size = new System.Drawing.Size(197, 86);
            this.buttonProeditSave.TabIndex = 114;
            this.buttonProeditSave.Text = "Save";
            this.buttonProeditSave.UseVisualStyleBackColor = true;
            // 
            // buttonProeditCancel
            // 
            this.buttonProeditCancel.Location = new System.Drawing.Point(181, 297);
            this.buttonProeditCancel.Name = "buttonProeditCancel";
            this.buttonProeditCancel.Size = new System.Drawing.Size(195, 76);
            this.buttonProeditCancel.TabIndex = 113;
            this.buttonProeditCancel.Text = "Cancel";
            this.buttonProeditCancel.UseVisualStyleBackColor = true;
            this.buttonProeditCancel.Click += new System.EventHandler(this.buttonProeditCancel_Click);
            // 
            // ProeditPrate
            // 
            this.ProeditPrate.Location = new System.Drawing.Point(385, 206);
            this.ProeditPrate.Name = "ProeditPrate";
            this.ProeditPrate.Size = new System.Drawing.Size(203, 20);
            this.ProeditPrate.TabIndex = 112;
            // 
            // ProeditPname
            // 
            this.ProeditPname.Location = new System.Drawing.Point(385, 116);
            this.ProeditPname.Name = "ProeditPname";
            this.ProeditPname.Size = new System.Drawing.Size(203, 20);
            this.ProeditPname.TabIndex = 111;
            // 
            // ProeditPcode
            // 
            this.ProeditPcode.Location = new System.Drawing.Point(385, 79);
            this.ProeditPcode.Name = "ProeditPcode";
            this.ProeditPcode.Size = new System.Drawing.Size(203, 20);
            this.ProeditPcode.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 109;
            this.label1.Text = "Rate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 108;
            this.label2.Text = "Pieces Per Catton :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 107;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 106;
            this.label4.Text = "Product Code :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 29);
            this.label5.TabIndex = 143;
            this.label5.Text = "Delete By Product Name :";
            // 
            // ProPnametoDelete
            // 
            this.ProPnametoDelete.Location = new System.Drawing.Point(419, 194);
            this.ProPnametoDelete.Name = "ProPnametoDelete";
            this.ProPnametoDelete.Size = new System.Drawing.Size(203, 20);
            this.ProPnametoDelete.TabIndex = 142;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 29);
            this.label6.TabIndex = 173;
            this.label6.Text = "Search By Product Name :";
            // 
            // ProsearchPname
            // 
            this.ProsearchPname.Location = new System.Drawing.Point(487, 178);
            this.ProsearchPname.Name = "ProsearchPname";
            this.ProsearchPname.Size = new System.Drawing.Size(203, 20);
            this.ProsearchPname.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 29);
            this.label7.TabIndex = 171;
            this.label7.Text = "Search By Product Code :";
            // 
            // ProsearchPcode
            // 
            this.ProsearchPcode.Location = new System.Drawing.Point(487, 111);
            this.ProsearchPcode.Name = "ProsearchPcode";
            this.ProsearchPcode.Size = new System.Drawing.Size(203, 20);
            this.ProsearchPcode.TabIndex = 170;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 733);
            this.Controls.Add(this.buttonProback);
            this.Controls.Add(this.ProductSettings);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.ProductSettings.ResumeLayout(false);
            this.Proadd.ResumeLayout(false);
            this.Proadd.PerformLayout();
            this.Proedit.ResumeLayout(false);
            this.Proedit.PerformLayout();
            this.Prodelete.ResumeLayout(false);
            this.Prodelete.PerformLayout();
            this.Prosearch.ResumeLayout(false);
            this.Prosearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProback;
        private System.Windows.Forms.TabControl ProductSettings;
        private System.Windows.Forms.TabPage Proadd;
        private System.Windows.Forms.Button buttonProaddSave;
        private System.Windows.Forms.Button buttonProaddCancel;
        private System.Windows.Forms.TextBox ProaddPrate;
        private System.Windows.Forms.TextBox ProaddPname;
        private System.Windows.Forms.TextBox ProaddPcode;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TabPage Proedit;
        private System.Windows.Forms.TabPage Prodelete;
        private System.Windows.Forms.Button buttonProdeleteDelete;
        private System.Windows.Forms.Button buttonProdeleteCancel;
        private System.Windows.Forms.Label hh;
        private System.Windows.Forms.TextBox ProPcodetoDelete;
        private System.Windows.Forms.TabPage Prosearch;
        private System.Windows.Forms.Button buttonProsearchSearch;
        private System.Windows.Forms.Button buttonProsearchCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ProaddPpieces;
        private System.Windows.Forms.TextBox ProeditPpieces;
        private System.Windows.Forms.Button buttonProeditSave;
        private System.Windows.Forms.Button buttonProeditCancel;
        private System.Windows.Forms.TextBox ProeditPrate;
        private System.Windows.Forms.TextBox ProeditPname;
        private System.Windows.Forms.TextBox ProeditPcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProPnametoDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProsearchPname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProsearchPcode;
    }
}