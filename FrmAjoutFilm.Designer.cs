namespace WindowsFormsApplication1
{
    partial class FrmAjoutFilm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rchTxtResume = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTitre = new System.Windows.Forms.TextBox();
			this.txtAnnee = new System.Windows.Forms.TextBox();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.txtPays = new System.Windows.Forms.TextBox();
			this.cmbActeur = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnNouvelActeur = new System.Windows.Forms.Button();
			this.btnValider = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.bdgSourceActeur = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceActeur)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Annee";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Genre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Pays";
			// 
			// rchTxtResume
			// 
			this.rchTxtResume.Location = new System.Drawing.Point(16, 197);
			this.rchTxtResume.Name = "rchTxtResume";
			this.rchTxtResume.Size = new System.Drawing.Size(173, 96);
			this.rchTxtResume.TabIndex = 4;
			this.rchTxtResume.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(78, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Résumé";
			// 
			// txtTitre
			// 
			this.txtTitre.Location = new System.Drawing.Point(99, 40);
			this.txtTitre.Name = "txtTitre";
			this.txtTitre.Size = new System.Drawing.Size(100, 20);
			this.txtTitre.TabIndex = 6;
			// 
			// txtAnnee
			// 
			this.txtAnnee.Location = new System.Drawing.Point(99, 75);
			this.txtAnnee.Name = "txtAnnee";
			this.txtAnnee.Size = new System.Drawing.Size(100, 20);
			this.txtAnnee.TabIndex = 7;
			// 
			// txtGenre
			// 
			this.txtGenre.Location = new System.Drawing.Point(99, 114);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.Size = new System.Drawing.Size(100, 20);
			this.txtGenre.TabIndex = 8;
			// 
			// txtPays
			// 
			this.txtPays.Location = new System.Drawing.Point(99, 150);
			this.txtPays.Name = "txtPays";
			this.txtPays.Size = new System.Drawing.Size(100, 20);
			this.txtPays.TabIndex = 9;
			// 
			// cmbActeur
			// 
			this.cmbActeur.DataSource = this.bdgSourceActeur;
			this.cmbActeur.DisplayMember = "nom";
			this.cmbActeur.FormattingEnabled = true;
			this.cmbActeur.Location = new System.Drawing.Point(216, 170);
			this.cmbActeur.Name = "cmbActeur";
			this.cmbActeur.Size = new System.Drawing.Size(121, 21);
			this.cmbActeur.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(253, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Acteur principal";
			// 
			// btnNouvelActeur
			// 
			this.btnNouvelActeur.Location = new System.Drawing.Point(262, 197);
			this.btnNouvelActeur.Name = "btnNouvelActeur";
			this.btnNouvelActeur.Size = new System.Drawing.Size(75, 23);
			this.btnNouvelActeur.TabIndex = 12;
			this.btnNouvelActeur.Text = "Nouveau";
			this.btnNouvelActeur.UseVisualStyleBackColor = true;
			this.btnNouvelActeur.Click += new System.EventHandler(this.btnNouvelActeur_Click);
			// 
			// btnValider
			// 
			this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnValider.Location = new System.Drawing.Point(216, 242);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(121, 34);
			this.btnValider.TabIndex = 13;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Id";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(99, 5);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 15;
			// 
			// bdgSourceActeur
			// 
			this.bdgSourceActeur.DataMember = "acteurs";
			this.bdgSourceActeur.DataSource = typeof(libActeursFilms.Cinema);
			// 
			// FrmAjoutFilm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 314);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.btnNouvelActeur);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbActeur);
			this.Controls.Add(this.txtPays);
			this.Controls.Add(this.txtGenre);
			this.Controls.Add(this.txtAnnee);
			this.Controls.Add(this.txtTitre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rchTxtResume);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmAjoutFilm";
			this.Text = "Ajouter un film";
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceActeur)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchTxtResume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.ComboBox cmbActeur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNouvelActeur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.BindingSource bdgSourceActeur;
	}
}