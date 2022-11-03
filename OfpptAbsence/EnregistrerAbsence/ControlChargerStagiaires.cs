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
    public partial class ControlChargerStagiaires : UserControl
    {
        Ado d = new Ado();
        Controle c = new Controle();
        FormUtilisateur utilisateur = new FormUtilisateur();

        public ControlChargerStagiaires(FormUtilisateur util)
        {
            InitializeComponent();
            utilisateur = util;

        }

        private void ControlChargerStagiaires_Load(object sender, EventArgs e)
        {
            this.DtAbss.Value = DateTime.Now;
            //this.DtAbss.

            try
            {
                d.Connecter();
                d.remplireCombobox("select Distinct GroupStagiaire from stagiaire order by GroupStagiaire asc", cmbGroup);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        public void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            d.remplireDataGridView("select * from stagiaire where GroupStagiaire='" + cmbGroup.Text + "'", dataGridView1);
            Controle.GroupSelect = cmbGroup.Text;
            {
                this.dataGridView1.Columns[2].HeaderText = "CEF";
                this.dataGridView1.Columns[3].HeaderText = "Nom";
                this.dataGridView1.Columns[4].HeaderText = "Prenom";
                this.dataGridView1.Columns[5].HeaderText = "Groupe";
                this.dataGridView1.Columns[6].HeaderText = "Cin";
                this.dataGridView1.Columns[7].HeaderText = "A Justifier";
                this.dataGridView1.Columns[8].HeaderText = "A Non Justifier";
                this.dataGridView1.Columns[9].HeaderText = "Retard";
            }
            {
                //this.dataGridView1.Columns[0].ReadOnly = false;
                for (int i=1;i<10;i++)
                {
                this.dataGridView1.Columns[i].ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    Controle.CefStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Controle.NomStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Controle.PrenomStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    Controle.GroupStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    ControlAbsence controlAbsence = new ControlAbsence();
                    FormUtilisateur.curentControl = controlAbsence;
                    c.AfficherControleur(controlAbsence, utilisateur.pnlShow);
                    utilisateur.btnRetour.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Selection un Stagiaire S.V.P!!");
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("voulez vous Valider L'absence ?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (rep == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value is true)
                    {
                        d.ExecuteRequete("exec ajouterAbsNonJustNormal '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "', '" + DtAbss.Value.ToString() + "' , 'Absence Non Justifier'") ;
                    }
                }
            }
            MessageBox.Show("Données Valide avec succées");
            cmbGroup_SelectedIndexChanged(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        Controle.CefStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //        Controle.NomStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        Controle.PrenomStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        Controle.GroupStagiaire = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        //        ControlAbsence controlAbsence = new ControlAbsence();
        //        c.AfficherControleur(controlAbsence, utilisateur.pnlShow);
        //        utilisateur.btnRetour.Visible = true;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Selection un Stagiaire S.V.P!!");
        //    }
        //}
    }
}
