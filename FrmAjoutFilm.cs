using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libActeursFilms;

namespace WindowsFormsApplication1
{
    public partial class FrmAjoutFilm : Form
    {
        private Cinema leCinema;
        public FrmAjoutFilm(Cinema c)
        {
            InitializeComponent();
            this.leCinema = c;
			this.cmbActeur.DataSource = this.leCinema.acteurs;
           
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.txtId.Text);
                string titre = this.txtTitre.Text;
                int annee = Convert.ToInt32(this.txtAnnee.Text);
                string genre = this.txtGenre.Text;
                string pays = this.txtPays.Text;
                string resume = this.rchTxtResume.Text;
				Acteur act = (Acteur)this.cmbActeur.SelectedItem;
				Film f;
				f = new Film(id, titre, genre, annee, pays, act, resume);
				this.leCinema.ajouterFilm(f);
				var res = MessageBox.Show("Le film est enregistre, fermer!!");
				if (res.ToString() == "ok")
					this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNouvelActeur_Click(object sender, EventArgs e)
        {
			FrmParcoursActeurs f;
			f = new FrmParcoursActeurs(this.leCinema);
			f.Show();
        }
    }
}
