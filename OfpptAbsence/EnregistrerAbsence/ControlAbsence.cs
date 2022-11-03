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
    public partial class ControlAbsence : UserControl
    {
        Controle c = new Controle();
       
        public ControlAbsence()
        {
            InitializeComponent();
        }

        private void ControlAbsence_Load(object sender, EventArgs e)
        {
            this.lblCef.Text = Controle.CefStagiaire;
            this.lblNom.Text = Controle.NomStagiaire;
            this.lblPrenom.Text = Controle.PrenomStagiaire;
            this.lblGroupe.Text = Controle.GroupStagiaire;

            if (Controle.TypeUtilisateur.Equals("Utilisateur standard"))
            {
                this.btnModifier.Enabled = false;
            }
        }

        private void btnAbsNonJust_Click(object sender, EventArgs e)
        {
            AbsNonJustControl absNonJustControl = new AbsNonJustControl();
            Controle.UserControl = absNonJustControl;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(absNonJustControl, pnlShow);
        }

        private void btnAbsStg_Click(object sender, EventArgs e)
        {
            AbsInformationControl absInformation = new AbsInformationControl();
            Controle.UserControl = absInformation;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(absInformation, pnlShow);
        }

        private void btnAbsJust_Click(object sender, EventArgs e)
        {
            AbsJustControl absJustControl = new AbsJustControl();
            Controle.UserControl = absJustControl;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(absJustControl, pnlShow);
        }

        private void btnRetard_Click(object sender, EventArgs e)
        {
            RetardControl retardControl = new RetardControl();
            Controle.UserControl = retardControl;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(retardControl, pnlShow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifierAbsControl modifierAbsControl = new ModifierAbsControl();
            Controle.UserControl = modifierAbsControl;
            Controle.currentPanel = pnlShow;
            c.AfficherControleur(modifierAbsControl, pnlShow);
        }
    }
}
