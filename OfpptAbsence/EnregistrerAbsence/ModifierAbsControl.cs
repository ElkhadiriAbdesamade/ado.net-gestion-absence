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
    public partial class ModifierAbsControl : UserControl
    {
        Ado d = new Ado();
        public ModifierAbsControl()
        {
            InitializeComponent();
        }

       

        private void ModifierAbsControl_Load(object sender, EventArgs e)
        {
            d.Connecter();
        }
        public void remplirGridView(String req,Boolean type)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;

            d.cmd = new SqlCommand(req,d.cn);
            d.dr = d.cmd.ExecuteReader();
            while(d.dr.Read())
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0].Value = d.dr[0].ToString();
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1].Value = d.dr[1].ToString();
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[2].Value = d.dr[2].ToString();
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[3].Value = d.dr[3].ToString();     
                if(!type)
                {
                    this.dataGridView1.Columns[4].Visible = true;
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[4].Value = d.dr[4].ToString();
                }
                else
                {
                    this.dataGridView1.Columns[5].Visible = true;
                    if (d.dr[5].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value= cmbEtat.Items[1];                       
                    }
                    else
                    if (d.dr[6].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[2];
                    }
                    else
                    if (d.dr[7].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[3];
                    }
                    else
                    if (d.dr[8].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[4];
                    }
                    else
                    if (d.dr[9].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[5];
                    }
                    else
                    if (d.dr[10].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[6];
                    }
                    else
                    if (d.dr[11].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[7];
                    }
                    else
                    if (d.dr[12].ToString() == "1")
                    {
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[8];
                    }
                    else
                        this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[5].Value = cmbEtat.Items[0];
                }
            }
            d.dr.Close();
        }

        private void btnAbsNonJust_Click(object sender, EventArgs e)
        {
            this.remplirGridView("select * from absence where cefstagiaire = '" + Controle.CefStagiaire + "' and TypeAbss = 'Absence Non Justifier'",true);
        }

        private void btnAbsJust_Click(object sender, EventArgs e)
        {
            this.remplirGridView("select * from absence where cefstagiaire = '" + Controle.CefStagiaire + "' and TypeAbss = 'Absence Justifier'", false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Modifier abss
            if (e.ColumnIndex == 6)
            {
                DialogResult rep;
                rep = MessageBox.Show("voulez vous Modifier?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (rep == DialogResult.Yes)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals("Absence Non Justifier"))
                    {
                        {
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Aucun"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("1 ére Mise en garde"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =1,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("2 éme Mise en garde"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=1,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("1 éme avertissement"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=1,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("2 éme avertissement"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=1,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Blâme"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=6,EtatSanction06=0,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Exclusion de 2 jours"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=1,EtatSanction07=0,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Exclusion temporaire"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=1,EtatSanction08=0 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                            else
                            if (this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Exclusion définitive"))
                            {
                                d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', EtatSanction01 =0,EtatSanction02=0,EtatSanction03=0,EtatSanction04=0,EtatSanction05=0,EtatSanction06=0,EtatSanction07=0,EtatSanction08=1 from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                            }
                        }
                        this.btnAbsNonJust_Click(sender,e);
                    }
                    else
                        if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals("Absence Justifier"))
                        {
                        d.ExecuteRequete("update absence set DateAbss = '" + this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "', DocumentDeJustification= '" + this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "' from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                        this.btnAbsJust_Click(sender, e);
                        }
                    MessageBox.Show("Absence Modifier");
                }
            }

            //supprimer abs
            if (e.ColumnIndex == 7)
            {
                DialogResult rep;
                rep = MessageBox.Show("voulez vous Supprimer?", "supprision", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (rep == DialogResult.Yes)
                {  
                    d.ExecuteRequete("delete from absence where IdAbsence='" + this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Absence Supprimer");
                    
                }
            }

            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.Equals("Absence Non Justifier"))
                this.btnAbsNonJust_Click(sender, e);
            else
                this.btnAbsJust_Click(sender, e);

        }
    }
}
