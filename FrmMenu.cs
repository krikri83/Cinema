using libActeursFilms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenu : Form
    {
        private Cinema leCinema;
        private string nomFichier;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            try
            {
                this.nomFichier = this.openFileDialog1.FileName;
                this.leCinema = Data.charge(nomFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show("format non valide");
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            try
            {
                this.nomFichier = this.openFileDialog1.FileName;
                Data.sauve(this.leCinema, nomFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show("format non valide");
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parcourirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.leCinema != null)
            {
                FrmParcoursFilms f = new FrmParcoursFilms(this.leCinema);
                f.Show();
            }
            else
                MessageBox.Show("Il faut charger le fichier de données !!");
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.leCinema != null)
            {
                FrmAjoutFilm f = new FrmAjoutFilm(this.leCinema);
                f.Show();
            }
            else
                MessageBox.Show("Il faut charger le fichier de données !!");

        }

        private void parcourirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.leCinema != null)
            {
                FrmParcoursActeurs f = new FrmParcoursActeurs(this.leCinema);
                f.Show();
            }
            else
                MessageBox.Show("Il faut charger le fichier de données !!");
        }

        private void chercherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.leCinema != null)
            {
                FrmChercherFilm f = new FrmChercherFilm(this.leCinema);
                f.Show();
            }
            else
                MessageBox.Show("Il faut charger le fichier de données !!");
        }
    }
}
