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
    public partial class FrmChercherFilm : Form
    {
        private Cinema leCinema;
        public FrmChercherFilm(Cinema c)
        {
            InitializeComponent();
            this.leCinema = c;
        }

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {
			string ch = this.txtTitre.Text;
			if(ch.Length > 1)
			{
				this.lstFilm.DataSource = this.leCinema.getFilms(ch);
				this.lstFilm.DisplayMember = "titre";
			}
        }

        private void lstFilm_DoubleClick(object sender, EventArgs e)
        {
			Film f = (Film)this.lstFilm.SelectedItem;
			this.txtAnnee.Text = f.annee.ToString();
			this.txtActeur.Text = f.acteurPrincipal.nom.ToString();
			this.txtGenre.Text = f.genre;
			this.txtPays.Text = f.pays;
			this.rchtxtResume.Text = f.resume;
			this.txtTitre.Text = "";
        }
    }
}
