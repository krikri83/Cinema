namespace WindowsFormsApplication1
{
    partial class FrmChercherFilm
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
			this.txtTitre = new System.Windows.Forms.TextBox();
			this.lstFilm = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rchtxtResume = new System.Windows.Forms.RichTextBox();
			this.txtPays = new System.Windows.Forms.TextBox();
			this.txtActeur = new System.Windows.Forms.TextBox();
			this.txtAnnee = new System.Windows.Forms.TextBox();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titre (recherche par mot)";
			// 
			// txtTitre
			// 
			this.txtTitre.Location = new System.Drawing.Point(152, 6);
			this.txtTitre.Name = "txtTitre";
			this.txtTitre.Size = new System.Drawing.Size(100, 20);
			this.txtTitre.TabIndex = 1;
			this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
			// 
			// lstFilm
			// 
			this.lstFilm.FormattingEnabled = true;
			this.lstFilm.Location = new System.Drawing.Point(31, 51);
			this.lstFilm.Name = "lstFilm";
			this.lstFilm.Size = new System.Drawing.Size(180, 95);
			this.lstFilm.TabIndex = 2;
			this.lstFilm.DoubleClick += new System.EventHandler(this.lstFilm_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rchtxtResume);
			this.groupBox1.Controls.Add(this.txtPays);
			this.groupBox1.Controls.Add(this.txtActeur);
			this.groupBox1.Controls.Add(this.txtAnnee);
			this.groupBox1.Controls.Add(this.txtGenre);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(31, 153);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 231);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Détail du film";
			// 
			// rchtxtResume
			// 
			this.rchtxtResume.Location = new System.Drawing.Point(19, 129);
			this.rchtxtResume.Name = "rchtxtResume";
			this.rchtxtResume.ReadOnly = true;
			this.rchtxtResume.Size = new System.Drawing.Size(202, 96);
			this.rchtxtResume.TabIndex = 8;
			this.rchtxtResume.Text = "";
			// 
			// txtPays
			// 
			this.txtPays.Location = new System.Drawing.Point(92, 97);
			this.txtPays.Name = "txtPays";
			this.txtPays.ReadOnly = true;
			this.txtPays.Size = new System.Drawing.Size(100, 20);
			this.txtPays.TabIndex = 7;
			// 
			// txtActeur
			// 
			this.txtActeur.Location = new System.Drawing.Point(92, 67);
			this.txtActeur.Name = "txtActeur";
			this.txtActeur.ReadOnly = true;
			this.txtActeur.Size = new System.Drawing.Size(100, 20);
			this.txtActeur.TabIndex = 6;
			// 
			// txtAnnee
			// 
			this.txtAnnee.Location = new System.Drawing.Point(92, 41);
			this.txtAnnee.Name = "txtAnnee";
			this.txtAnnee.ReadOnly = true;
			this.txtAnnee.Size = new System.Drawing.Size(100, 20);
			this.txtAnnee.TabIndex = 5;
			// 
			// txtGenre
			// 
			this.txtGenre.Location = new System.Drawing.Point(92, 11);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.ReadOnly = true;
			this.txtGenre.Size = new System.Drawing.Size(100, 20);
			this.txtGenre.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Pays";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Acteur principal";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Année";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Genre";
			// 
			// FrmChercherFilm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 407);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstFilm);
			this.Controls.Add(this.txtTitre);
			this.Controls.Add(this.label1);
			this.Name = "FrmChercherFilm";
			this.Text = "Chercher un film";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ListBox lstFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchtxtResume;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.TextBox txtActeur;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
	}
}