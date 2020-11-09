namespace WindowsFormsApplication1
{
    partial class FrmParcoursActeurs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcoursActeurs));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.bdgSourceActeurs = new System.Windows.Forms.BindingSource(this.components);
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.txtAnnee = new System.Windows.Forms.TextBox();
			this.bdgNavActeurs = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceActeurs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bdgNavActeurs)).BeginInit();
			this.bdgNavActeurs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prénom";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Année de naissance";
			// 
			// txtNom
			// 
			this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceActeurs, "nom", true));
			this.txtNom.Location = new System.Drawing.Point(131, 48);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(100, 20);
			this.txtNom.TabIndex = 3;
			// 
			// bdgSourceActeurs
			// 
			this.bdgSourceActeurs.DataMember = "acteurs";
			this.bdgSourceActeurs.DataSource = typeof(libActeursFilms.Cinema);
			// 
			// txtPrenom
			// 
			this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceActeurs, "prenom", true));
			this.txtPrenom.Location = new System.Drawing.Point(131, 96);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(100, 20);
			this.txtPrenom.TabIndex = 4;
			// 
			// txtAnnee
			// 
			this.txtAnnee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceActeurs, "anneeNaissance", true));
			this.txtAnnee.Location = new System.Drawing.Point(151, 132);
			this.txtAnnee.Name = "txtAnnee";
			this.txtAnnee.Size = new System.Drawing.Size(100, 20);
			this.txtAnnee.TabIndex = 5;
			// 
			// bdgNavActeurs
			// 
			this.bdgNavActeurs.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bdgNavActeurs.BindingSource = this.bdgSourceActeurs;
			this.bdgNavActeurs.CountItem = this.bindingNavigatorCountItem;
			this.bdgNavActeurs.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bdgNavActeurs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.bdgNavActeurs.Location = new System.Drawing.Point(0, 0);
			this.bdgNavActeurs.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bdgNavActeurs.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bdgNavActeurs.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bdgNavActeurs.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bdgNavActeurs.Name = "bdgNavActeurs";
			this.bdgNavActeurs.PositionItem = this.bindingNavigatorPositionItem;
			this.bdgNavActeurs.Size = new System.Drawing.Size(284, 25);
			this.bdgNavActeurs.TabIndex = 6;
			this.bdgNavActeurs.Text = "bindingNavigator1";
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
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titre,
            this.annee});
			this.dataGridView1.DataSource = this.filmsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(32, 176);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 7;
			// 
			// filmsBindingSource
			// 
			this.filmsBindingSource.DataMember = "films";
			this.filmsBindingSource.DataSource = this.bdgSourceActeurs;
			// 
			// titre
			// 
			this.titre.DataPropertyName = "titre";
			this.titre.HeaderText = "titre";
			this.titre.Name = "titre";
			// 
			// annee
			// 
			this.annee.DataPropertyName = "annee";
			this.annee.HeaderText = "Annee";
			this.annee.Name = "annee";
			// 
			// FrmParcoursActeurs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 338);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bdgNavActeurs);
			this.Controls.Add(this.txtAnnee);
			this.Controls.Add(this.txtPrenom);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmParcoursActeurs";
			this.Text = "Parcourir les acteurs";
			((System.ComponentModel.ISupportInitialize)(this.bdgSourceActeurs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bdgNavActeurs)).EndInit();
			this.bdgNavActeurs.ResumeLayout(false);
			this.bdgNavActeurs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAnnee;
		private System.Windows.Forms.BindingSource bdgSourceActeurs;
		private System.Windows.Forms.BindingNavigator bdgNavActeurs;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titre;
		private System.Windows.Forms.DataGridViewTextBoxColumn annee;
		private System.Windows.Forms.BindingSource filmsBindingSource;
	}
}