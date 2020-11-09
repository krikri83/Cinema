namespace WindowsFormsApplication1
{
    partial class FrmParcoursFilms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcoursFilms));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rchTxtResume = new System.Windows.Forms.RichTextBox();
			this.bdgSourceCinema = new System.Windows.Forms.BindingSource(this.components);
			this.txtTitre = new System.Windows.Forms.TextBox();
			this.txtAnnee = new System.Windows.Forms.TextBox();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.txtActeur = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bdgNavCinema = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceCinema)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdgNavCinema)).BeginInit();
			this.bdgNavCinema.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Genre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(172, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Année";
			// 
			// rchTxtResume
			// 
			this.rchTxtResume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceCinema, "resume", true));
			this.rchTxtResume.Location = new System.Drawing.Point(23, 147);
			this.rchTxtResume.Name = "rchTxtResume";
			this.rchTxtResume.ReadOnly = true;
			this.rchTxtResume.Size = new System.Drawing.Size(236, 111);
			this.rchTxtResume.TabIndex = 4;
			this.rchTxtResume.Text = "";
			// 
			// bdgSourceCinema
			// 
			this.bdgSourceCinema.DataMember = "films";
			this.bdgSourceCinema.DataSource = typeof(libActeursFilms.Cinema);
			// 
			// txtTitre
			// 
			this.txtTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceCinema, "titre", true));
			this.txtTitre.Location = new System.Drawing.Point(47, 32);
			this.txtTitre.Name = "txtTitre";
			this.txtTitre.ReadOnly = true;
			this.txtTitre.Size = new System.Drawing.Size(100, 20);
			this.txtTitre.TabIndex = 5;
			// 
			// txtAnnee
			// 
			this.txtAnnee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceCinema, "annee", true));
			this.txtAnnee.Location = new System.Drawing.Point(229, 32);
			this.txtAnnee.Name = "txtAnnee";
			this.txtAnnee.ReadOnly = true;
			this.txtAnnee.Size = new System.Drawing.Size(53, 20);
			this.txtAnnee.TabIndex = 6;
			// 
			// txtGenre
			// 
			this.txtGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceCinema, "genre", true));
			this.txtGenre.Location = new System.Drawing.Point(47, 65);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.ReadOnly = true;
			this.txtGenre.Size = new System.Drawing.Size(100, 20);
			this.txtGenre.TabIndex = 7;
			// 
			// txtActeur
			// 
			this.txtActeur.Location = new System.Drawing.Point(125, 114);
			this.txtActeur.Name = "txtActeur";
			this.txtActeur.ReadOnly = true;
			this.txtActeur.Size = new System.Drawing.Size(100, 20);
			this.txtActeur.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Acteur principal";
			// 
			// bdgNavCinema
			// 
			this.bdgNavCinema.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bdgNavCinema.BindingSource = this.bdgSourceCinema;
			this.bdgNavCinema.CountItem = this.bindingNavigatorCountItem;
			this.bdgNavCinema.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bdgNavCinema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bdgNavCinema.Location = new System.Drawing.Point(0, 0);
			this.bdgNavCinema.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bdgNavCinema.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bdgNavCinema.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bdgNavCinema.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bdgNavCinema.Name = "bdgNavCinema";
			this.bdgNavCinema.PositionItem = this.bindingNavigatorPositionItem;
			this.bdgNavCinema.Size = new System.Drawing.Size(284, 25);
			this.bdgNavCinema.TabIndex = 12;
			this.bdgNavCinema.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Supprimer";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// FrmParcoursFilms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.bdgNavCinema);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtActeur);
			this.Controls.Add(this.txtGenre);
			this.Controls.Add(this.txtAnnee);
			this.Controls.Add(this.txtTitre);
			this.Controls.Add(this.rchTxtResume);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmParcoursFilms";
			this.Text = "Parcourir les films";
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceCinema)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdgNavCinema)).EndInit();
			this.bdgNavCinema.ResumeLayout(false);
			this.bdgNavCinema.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchTxtResume;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtActeur;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingNavigator bdgNavCinema;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.BindingSource bdgSourceCinema;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
	}
}