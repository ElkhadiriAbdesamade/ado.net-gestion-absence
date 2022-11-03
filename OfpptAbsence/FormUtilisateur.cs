using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfpptAbsence
{
    public partial class FormUtilisateur : Form
    {

        Controle c = new Controle();
        Button curentButton ;
       public static UserControl curentControl;
        public FormUtilisateur()
        {
            InitializeComponent();
            pnlShow.BringToFront();
        }
        

        private void MoveSidePanel(Control c)
        {
            pnlBtn.Height = c.Height;
            pnlBtn.Top = c.Top;
        }

       
        

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnEnregistAbs_Click_1(object sender, EventArgs e)
        {
            curentButton = btnEnregistAbs;
            MoveSidePanel(curentButton);
            ControlChargerStagiaires chargerStagiaires = new ControlChargerStagiaires(this);
            curentControl = chargerStagiaires;
            c.AfficherControleur(chargerStagiaires, pnlShow);
            this.btnRetour.Visible = false;
        }

        private void btnChercherAbs_Click_1(object sender, EventArgs e)
        {
            curentButton = btnChercherAbs;
            MoveSidePanel(curentButton);
            ControlRecherch controlRecherch = new ControlRecherch();
            curentControl =controlRecherch ;
            c.AfficherControleur(controlRecherch, pnlShow);
            this.btnRetour.Visible = false;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            curentButton = btnImportExcel;
            MoveSidePanel(curentButton);
            StagiaireControl stagiaireControl = new StagiaireControl();
            curentControl = stagiaireControl;
            c.AfficherControleur(stagiaireControl , pnlShow);
            this.btnRetour.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            curentButton = btnHome;
            MoveSidePanel(curentButton);
            pnlShow.Controls.Clear();
            this.btnRetour.Visible = false;
        }

        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            //Controle.TypeUtilisateur = "A";
            //Controle.TypeUtilisateur = "Utilisateur standard";
            if (Controle.TypeUtilisateur.Equals("Utilisateur standard"))
            {
                //this.btnImportExcel.Visible = false;
                //this.btnUser.Visible = false;
                this.btnImportExcel.Enabled = false;
                this.btnUser.Enabled = false;
            }            
            this.LblNomUtilisateur.Text = Controle.NomUtilisateur;
            this.lblType.Text = Controle.TypeUtilisateur;
            btnHome_Click(sender, e);
            bunifuImageButton1_Click(sender, e);
            curentButton = this.btnHome;
            //currentPanel = this.pnlShow;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            ControlChargerStagiaires chargerStagiaires = new ControlChargerStagiaires(this);
            chargerStagiaires.cmbGroup.Text = Controle.GroupSelect;
            c.AfficherControleur(chargerStagiaires, pnlShow);
            chargerStagiaires.cmbGroup_SelectedIndexChanged(sender, e);
            this.btnRetour.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            curentButton = btnUser;
            MoveSidePanel(curentButton);
            GestionUserControl userControl = new GestionUserControl();
            curentControl =userControl ;
            c.AfficherControleur(userControl, pnlShow);
            this.btnRetour.Visible = false;
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                this.btnMax.Image = Properties.Resources.full_screen_32px;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.btnMax.Image = Properties.Resources.normal_screen_32px;
            }
            MoveSidePanel(curentButton);
            if (curentControl != null)
                c.AdabteControle(curentControl, pnlShow);

            if (Controle.UserControl != null)
                c.AdabteControle(Controle.UserControl, Controle.currentPanel);
        }
    }
}
