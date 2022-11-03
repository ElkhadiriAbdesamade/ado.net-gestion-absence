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
    public partial class NouveauStagiaireControl : UserControl
    {
        Ado d = new Ado();
        public NouveauStagiaireControl()
        {
            InitializeComponent();
        }

        private void NouveauStagiaireControl_Load(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                d.remplireCombobox("select Distinct GroupStagiaire from stagiaire order by GroupStagiaire asc", cmbGroup);
                this.btnModifier.Enabled = false;
                this.btnSupprimer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            d.vidder(this);
            d.vidder(groupBox1);
            d.vidder(tableLayoutPanel6);
            this.txtCef.Enabled = true;
            this.txtCef.Focus();
            this.cmbGroup.Text = "";
            this.btnModifier.Enabled = false;
            this.btnSupprimer.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(d.testvide(tableLayoutPanel6))
            {
                d.cmd = new SqlCommand("select * from Stagiaire where CefStagiaire = '" + this.txtCef.Text + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.HasRows)
                {
                    MessageBox.Show("Désolé ce Stagiaire existe déja");
                    this.txtCef.Text="";
                    this.txtCef.Focus();
                    d.dr.Close();
                }
                else
                {
                    d.dr.Close();
                    d.ExecuteRequete("insert into Stagiaire values ('" + this.txtCef.Text + "','" + this.txtNom.Text + "','" + this.txtPrenom.Text + "','" + this.cmbGroup.Text + "','" + this.txtCin.Text + "',0,0,0)");
                    MessageBox.Show("Opération terminée avec succés");
                }
            }

            btnNouveau_Click(sender, e);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            d.ExecuteRequete("update Stagiaire set nomstagiaire='" + this.txtNom.Text + "', prenomStagiaire='" + this.txtPrenom.Text + "',GroupStagiaire='" + this.cmbGroup.Text + "',cinStagiaire='" + this.txtCin.Text + "'where cefStagiaire ='"+this.txtCef.Text+"'");
            MessageBox.Show("Opération terminée avec succés");
            btnNouveau_Click(sender, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("voulez vous supprimer?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (rep == DialogResult.Yes)
            {
                d.ExecuteRequete("exec SuprimerStagiaire '" + this.txtCef.Text + "'");
                MessageBox.Show("Opération terminée avec succés");
                btnNouveau_Click(sender, e);
            }
        }

        private void btnCherche_Click(object sender, EventArgs e)
        {
            d.cmd = new SqlCommand("select * from stagiaire where cefStagiaire = '" + this.txtRecherch.Text + "'", d.cn);
            d.dr = d.cmd.ExecuteReader();
            if (d.dr.HasRows)
            {
                while (d.dr.Read())
                {
                    this.txtCef.Text = d.dr[0].ToString();
                    this.txtNom.Text = d.dr[1].ToString();
                    this.txtPrenom.Text= d.dr[2].ToString();
                    this.cmbGroup.Text = d.dr[3].ToString();
                    this.txtCin.Text= d.dr[4].ToString();
                    this.btnModifier.Enabled = true;
                    this.btnSupprimer.Enabled = true;
                    this.txtCef.Enabled = false;
                }               
            }
            else
            {
                MessageBox.Show("Stagiaire Ne Exist Pas !!");
                this.txtRecherch.Text = "";
                this.txtRecherch.Focus();
            }
            d.dr.Close();
        }
    
    }
}
