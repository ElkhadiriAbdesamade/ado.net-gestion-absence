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
    public partial class GestionUserControl : UserControl
    {
        Ado d = new Ado();
        public GestionUserControl()
        {
            InitializeComponent();
        }

        private void GestionUserControl_Load(object sender, EventArgs e)
        {

            d.Connecter();
            d.remplireDataGridView("select * from utilisateur", this.dataGridView1);
            this.btnModifier.Enabled = false;
            this.btnSupprimer.Enabled = false;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            d.vidder(this);
            d.vidder(tableLayoutPanel3);
            this.txtNom.Focus();
            GestionUserControl_Load(sender, e);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (d.testvide(tableLayoutPanel3))
            {
                d.cmd = new SqlCommand("select * from Utilisateur where login = '" + this.txtLogin.Text + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.HasRows)
                {
                    MessageBox.Show("Désolé ce Utilisateur existe déja");
                    this.txtLogin.Text = "";
                    this.txtLogin.Focus();
                    d.dr.Close();
                }
                else
                {
                    d.dr.Close();
                    d.ExecuteRequete("insert into Utilisateur values ('" + this.txtNom.Text + "','" + this.txtLogin.Text + "','" + this.txtMpass.Text + "','" + this.cmbType.Text + "')");
                    MessageBox.Show("Opération terminée avec succés");
                }
            }
            btnNouveau_Click(sender, e);
            GestionUserControl_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtNom.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtLogin.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtMpass.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("Administrateur"))
                { this.cmbType.Text = cmbType.Items[0].ToString();}
                else { this.cmbType.Text = cmbType.Items[1].ToString(); }

                this.btnModifier.Enabled = true;
                this.btnSupprimer.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Selection un Utilisateur S.V.P!!");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("voulez vous Modifier?", "Modificassion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (d.testvide(this))
                if (rep == DialogResult.Yes)
            {
                d.ExecuteRequete("update Utilisateur set nomUtilisateur='" + this.txtNom.Text + "', Password='" + this.txtMpass.Text + "',TypeUser='" + this.cmbType.Text + "'where login ='" + this.txtLogin.Text + "'");
                MessageBox.Show("Opération terminée avec succés");
                btnNouveau_Click(sender, e);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("voulez vous supprimer?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (rep == DialogResult.Yes)
            {
                d.ExecuteRequete("delete from utilisateur where login ='" + this.txtLogin.Text + "'");
                MessageBox.Show("Opération terminée avec succés");
                btnNouveau_Click(sender, e);
            }
        }
    }
}
