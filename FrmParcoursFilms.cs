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
    public partial class FrmParcoursFilms : Form
    {
        private Cinema leCinema;
        public FrmParcoursFilms(Cinema c)
        {
            InitializeComponent();
            this.leCinema = c;
			this.bdgSourceCinema.DataSource = this.leCinema.films;
			this.txtActeur.DataBindings.Add("text", bdgSourceCinema, "acteurPrincipal.nom");
            // Ajouter code de chargement des BindingSources et de liaison avec le DatagridView
        }
    }
}
