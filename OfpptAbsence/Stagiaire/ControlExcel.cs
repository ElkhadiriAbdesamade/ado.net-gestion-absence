using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace OfpptAbsence
{
    public partial class ControlExcel : UserControl
    {
        Button Button;
        public ControlExcel(Button button)
        {
            InitializeComponent();
            this.Button = button;
        }

        Ado d = new Ado();

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
                //dataGridView1.DataSource = dt;
                List<Stagiaire> stagiaires = new List<Stagiaire>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Stagiaire stagiaire = new Stagiaire();
                    stagiaire.CefStagiaire = dt.Rows[i]["CefStagiaire"].ToString();
                    stagiaire.NomStagiaire = dt.Rows[i]["Nom"].ToString();
                    stagiaire.PrenomStagiaire = dt.Rows[i]["Prenom"].ToString();
                    stagiaire.GroupStagiaire = dt.Rows[i]["Groupe"].ToString();
                    stagiaire.CinStagiaire = dt.Rows[i]["Cin"].ToString();
                    stagiaires.Add(stagiaire);
                }
                dataGridView1.DataSource = stagiaires;
                //stagiaireBindingSource.DataSource = stagiaires;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog() { Filter= "Excel WorkBook|*.xlsx|Excel 97-2003 WorkBook|*.xls" })
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                cboSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    cboSheet.Items.Add(table.TableName); //Add sheet to comboBox
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                         
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Choisir un Excel S.V.P ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(this.Button.Text.Equals("Nouvelle Année"))
                    {
                        d.ExecuteRequete("exec SuprimerLesStagiaires");
                    }
                    string connectionString = "integrated security=true; initial catalog=OfpptAbsence";
                    DapperPlusManager.Entity<Stagiaire>().Table("stagiaire");
                    List<Stagiaire> stagiaires = dataGridView1.DataSource as List<Stagiaire>;
                    if (stagiaires != null)
                    {
                        using (IDbConnection db = new SqlConnection(connectionString))
                        {
                            db.BulkInsert(stagiaires);
                        }
                    }
                    MessageBox.Show("Opération terminée avec succés");
                    if (this.Button.Text.Equals("Nouvelle Année"))
                    {
                        d.ExecuteRequete(" Update Stagiaire set NombreAbsenceJust= 0 ,NombreAbsenceNonJust=0 , NombreRetard=0");
                    }
                    else
                    {
                        if (this.Button.Text.Equals("Nouveau Groupe"))
                        {
                            d.ExecuteRequete(" Update Stagiaire set NombreAbsenceJust= 0 ,NombreAbsenceNonJust=0 , NombreRetard=0 where GroupStagiaire='"+this.dataGridView1.Rows[1].Cells[3].Value.ToString()+"'");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ControlExcel_Load(object sender, EventArgs e)
        {
            if (this.Button.Text.Equals("Nouvelle Année"))
            {
                MessageBox.Show("Veuillez prendre l'attention que ce processus a lieu une fois par an", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // DialogResult dialogResult = MessageBox.Show("voulez vous supprimer?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            d.Connecter();
        }
    }
}
