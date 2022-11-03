using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfpptAbsence
{
    public partial class ControlRecherch : UserControl
    {
        private string typeRecherch="";
        Ado d = new Ado();
        Controle c = new Controle();

        public ControlRecherch()
        {
            InitializeComponent();
        }
        public void champeChoisir(string tp,string lb)
        {
            this.typeRecherch = tp;
            this.lblType.Text = lb;
            this.lblType.Visible = true;
            this.txtRecherch.Enabled = true;
        }
        public void radioCheked()
        {
            if(this.rdCef.Checked)
            {
                this.champeChoisir("CefStagiaire", "CEF :");               
            }
            else
                if (this.rdNom.Checked)
            {
                this.champeChoisir( "NomStagiaire","Nom :" );
            }
            else
                if (this.rdPrenom.Checked)
            {
                this.champeChoisir("PrenomStagiaire","Prenom :" );
            }
            else
                if (this.rdCin.Checked)
            {
                this.champeChoisir("CinStagiaire",  "CIN :");
            }
            


        }

        private void ControlRecherch_Load(object sender, EventArgs e)
        {
            d.Connecter();
        }

        private void rdCef_CheckedChanged(object sender, EventArgs e)
        {
            this.radioCheked();
        }

        private void rdNom_CheckedChanged(object sender, EventArgs e)
        {
            this.radioCheked();
        }

        private void rdPrenom_CheckedChanged(object sender, EventArgs e)
        {
            this.radioCheked();
        }

        private void rdCin_CheckedChanged(object sender, EventArgs e)
        {
            this.radioCheked();
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (this.txtRecherch.Enabled == false)
            {
                MessageBox.Show("Veuillez choisir une méthode de recherche  S.V.P ");
            }
            else
            if (this.txtRecherch.Text.Equals(""))
            {
                MessageBox.Show("S'il veous Plait remplir le contenu !!!");
                this.txtRecherch.Focus();
            }
            else
            {

                d.cmd = new SqlCommand("select * from stagiaire where " + typeRecherch + " = '" + this.txtRecherch.Text + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.HasRows)
                {
                    while (d.dr.Read())
                    {
                        this.lblCef.Text = Controle.CefStagiaire = d.dr[0].ToString();
                        this.lblNom.Text = Controle.NomStagiaire = d.dr[1].ToString();
                        this.lblPrenom.Text = Controle.PrenomStagiaire = d.dr[2].ToString();
                        this.lblGroupe.Text = Controle.GroupStagiaire = d.dr[3].ToString();
                        this.lblCin.Text = Controle.CinStagiaire = d.dr[4].ToString();
                    }
                    this.lblCef.Visible = true;
                    this.lblNom.Visible = true;
                    this.lblPrenom.Visible = true;
                    this.lblGroupe.Visible = true;
                    this.lblCin.Visible = true;
                    AbsInformationControl absInformation = new AbsInformationControl();
                    Controle.UserControl = absInformation;
                    Controle.currentPanel = pnlShow;
                    c.AfficherControleur(absInformation, pnlShow);
                }
                else
                {
                    MessageBox.Show("Stagiaire Ne Exist Pas !!");
                }
                d.dr.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
