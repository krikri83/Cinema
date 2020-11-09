namespace WindowsFormsApplication1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesFilmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcourirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesActeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parcourirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.lesFilmsToolStripMenuItem,
            this.lesActeursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "fichier sr|*.sr";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // lesFilmsToolStripMenuItem
            // 
            this.lesFilmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parcourirToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.chercherToolStripMenuItem});
            this.lesFilmsToolStripMenuItem.Name = "lesFilmsToolStripMenuItem";
            this.lesFilmsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.lesFilmsToolStripMenuItem.Text = "les Films";
            // 
            // parcourirToolStripMenuItem
            // 
            this.parcourirToolStripMenuItem.Name = "parcourirToolStripMenuItem";
            this.parcourirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parcourirToolStripMenuItem.Text = "Parcourir";
            this.parcourirToolStripMenuItem.Click += new System.EventHandler(this.parcourirToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // chercherToolStripMenuItem
            // 
            this.chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            this.chercherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chercherToolStripMenuItem.Text = "Chercher";
            this.chercherToolStripMenuItem.Click += new System.EventHandler(this.chercherToolStripMenuItem_Click);
            // 
            // lesActeursToolStripMenuItem
            // 
            this.lesActeursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parcourirToolStripMenuItem1});
            this.lesActeursToolStripMenuItem.Name = "lesActeursToolStripMenuItem";
            this.lesActeursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.lesActeursToolStripMenuItem.Text = "Les acteurs";
            // 
            // parcourirToolStripMenuItem1
            // 
            this.parcourirToolStripMenuItem1.Name = "parcourirToolStripMenuItem1";
            this.parcourirToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.parcourirToolStripMenuItem1.Text = "Gérer les acteurs";
            this.parcourirToolStripMenuItem1.Click += new System.EventHandler(this.parcourirToolStripMenuItem1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Cinéma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesFilmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcourirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesActeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parcourirToolStripMenuItem1;
    }
}

