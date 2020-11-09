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
    public partial class FrmParcoursActeurs : Form
    {
        private Cinema leCinema;
        public FrmParcoursActeurs(Cinema c)
        {
            InitializeComponent();
            this.leCinema = c;
			this.bdgSourceActeurs.DataSource = this.leCinema.acteurs;
			
			
           // ajouter code de chargement des bindingSources
        }
    }
}
