using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfpptAbsence
{
    public partial class StagiaireControl : UserControl
    {
        Controle c = new Controle();

        public StagiaireControl()
        {
            InitializeComponent();
        }

        private void btnNvAnnee_Click(object sender, EventArgs e)
        {
            ControlExcel controlExcel = new ControlExcel(btnNvAnnee);
            Controle.UserControl = controlExcel;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(controlExcel, pnlShow);
        }

        private void btnNouvStg_Click(object sender, EventArgs e)
        {
            NouveauStagiaireControl nouveauStagiaire = new NouveauStagiaireControl();
            Controle.UserControl = nouveauStagiaire;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(nouveauStagiaire, pnlShow);
        }

        private void btnNvGroupe_Click(object sender, EventArgs e)
        {
            ControlExcel controlExcel = new ControlExcel(btnNvGroupe);
            Controle.UserControl = controlExcel;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(controlExcel, pnlShow);
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
