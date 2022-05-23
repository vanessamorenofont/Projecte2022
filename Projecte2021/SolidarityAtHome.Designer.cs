namespace Projecte2021
{
    partial class SolidarityAtHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolidarityAtHome));
            this.obrirFitxer = new System.Windows.Forms.OpenFileDialog();
            this.butObrirFitxer = new System.Windows.Forms.Button();
            this.texFitxer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOpcions = new System.Windows.Forms.ComboBox();
            this.cmbSecundari = new System.Windows.Forms.ComboBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.rtbDades = new System.Windows.Forms.RichTextBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.butAppend = new System.Windows.Forms.Button();
            this.labErrors = new System.Windows.Forms.Label();
            this.lbTitol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butObrirFitxer
            // 
            this.butObrirFitxer.Location = new System.Drawing.Point(504, 127);
            this.butObrirFitxer.Name = "butObrirFitxer";
            this.butObrirFitxer.Size = new System.Drawing.Size(97, 23);
            this.butObrirFitxer.TabIndex = 0;
            this.butObrirFitxer.Text = "Load data file";
            this.butObrirFitxer.UseVisualStyleBackColor = true;
            this.butObrirFitxer.Click += new System.EventHandler(this.butObrirFitxer_Click);
            // 
            // texFitxer
            // 
            this.texFitxer.Location = new System.Drawing.Point(64, 129);
            this.texFitxer.Name = "texFitxer";
            this.texFitxer.Size = new System.Drawing.Size(363, 20);
            this.texFitxer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // cmbOpcions
            // 
            this.cmbOpcions.FormattingEnabled = true;
            this.cmbOpcions.Location = new System.Drawing.Point(64, 167);
            this.cmbOpcions.Name = "cmbOpcions";
            this.cmbOpcions.Size = new System.Drawing.Size(190, 21);
            this.cmbOpcions.TabIndex = 3;
            this.cmbOpcions.SelectedIndexChanged += new System.EventHandler(this.cmbOpcions_SelectedIndexChanged);
            // 
            // cmbSecundari
            // 
            this.cmbSecundari.FormattingEnabled = true;
            this.cmbSecundari.Location = new System.Drawing.Point(271, 167);
            this.cmbSecundari.Name = "cmbSecundari";
            this.cmbSecundari.Size = new System.Drawing.Size(156, 21);
            this.cmbSecundari.TabIndex = 4;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(443, 165);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(158, 23);
            this.butSearch.TabIndex = 5;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // rtbDades
            // 
            this.rtbDades.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbDades.Location = new System.Drawing.Point(64, 240);
            this.rtbDades.Name = "rtbDades";
            this.rtbDades.Size = new System.Drawing.Size(537, 149);
            this.rtbDades.TabIndex = 6;
            this.rtbDades.Text = "";
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(443, 127);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(55, 23);
            this.butOpen.TabIndex = 8;
            this.butOpen.Text = "...";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butAppend
            // 
            this.butAppend.Location = new System.Drawing.Point(443, 203);
            this.butAppend.Name = "butAppend";
            this.butAppend.Size = new System.Drawing.Size(158, 23);
            this.butAppend.TabIndex = 9;
            this.butAppend.Text = "Append";
            this.butAppend.UseVisualStyleBackColor = true;
            this.butAppend.Click += new System.EventHandler(this.butAppend_Click);
            // 
            // labErrors
            // 
            this.labErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labErrors.Location = new System.Drawing.Point(64, 404);
            this.labErrors.Name = "labErrors";
            this.labErrors.Size = new System.Drawing.Size(537, 20);
            this.labErrors.TabIndex = 10;
            // 
            // lbTitol
            // 
            this.lbTitol.AutoSize = true;
            this.lbTitol.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitol.Location = new System.Drawing.Point(346, 12);
            this.lbTitol.Name = "lbTitol";
            this.lbTitol.Size = new System.Drawing.Size(255, 43);
            this.lbTitol.TabIndex = 11;
            this.lbTitol.Text = "Solidarity At Home";
            this.lbTitol.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SolidarityAtHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitol);
            this.Controls.Add(this.labErrors);
            this.Controls.Add(this.butAppend);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.rtbDades);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.cmbSecundari);
            this.Controls.Add(this.cmbOpcions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texFitxer);
            this.Controls.Add(this.butObrirFitxer);
            this.Name = "SolidarityAtHome";
            this.Text = "Solidarity At Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog obrirFitxer;
        private System.Windows.Forms.Button butObrirFitxer;
        private System.Windows.Forms.TextBox texFitxer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOpcions;
        private System.Windows.Forms.ComboBox cmbSecundari;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.RichTextBox rtbDades;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butAppend;
        private System.Windows.Forms.Label labErrors;
        private System.Windows.Forms.Label lbTitol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}