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
    public partial class AbsNonJustControl : UserControl
    {
        Ado d = new Ado();
        Controle c = new Controle();
        int idAbs = 0;
        public AbsNonJustControl()
        {
            InitializeComponent();
        }



        private void AbsNonJustControl_Load(object sender, EventArgs e)
        {
            d.Connecter();

            this.DtAbss.Value = DateTime.Now;

            d.cmd = new SqlCommand("select EtatSanction01,EtatSanction02,EtatSanction03,EtatSanction04,EtatSanction05,EtatSanction06,EtatSanction07,EtatSanction08 from absence where cefstagiaire='" + Controle.CefStagiaire + "'", d.cn);
            d.dr = d.cmd.ExecuteReader();
            if (d.dr.HasRows)
            {
                while (d.dr.Read())
                {
                    if (d.dr[0].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                    }
                    if (d.dr[1].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                    }
                    if (d.dr[2].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                        rdSanction03.Enabled = false;
                    }
                    if (d.dr[3].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                        rdSanction03.Enabled = false;
                        rdSanction04.Enabled = false;
                    }
                    if (d.dr[4].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                        rdSanction03.Enabled = false;
                        rdSanction04.Enabled = false;
                        rdSanction05.Enabled = false;
                    }
                    if (d.dr[5].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                        rdSanction03.Enabled = false;
                        rdSanction04.Enabled = false;
                        rdSanction05.Enabled = false;
                        rdSanction06.Enabled = false;
                    }
                    if (d.dr[6].ToString() == "1")
                    {
                        rdSanction01.Enabled = false;
                        rdSanction02.Enabled = false;
                        rdSanction03.Enabled = false;
                        rdSanction04.Enabled = false;
                        rdSanction05.Enabled = false;
                        rdSanction06.Enabled = false;
                        rdSanction07.Enabled = false;
                    }
                }
            }

            d.dr.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            String etatSanction = "";
         //test Sanction
            {
                if (rdSanction01.Checked)
                {
                    etatSanction = "EtatSanction01";
                }
                if (rdSanction02.Checked)
                {
                    etatSanction = "EtatSanction02";
                }
                if (rdSanction03.Checked)
                {
                    etatSanction = "EtatSanction03";
                }
                if (rdSanction04.Checked)
                {
                    etatSanction = "EtatSanction04";
                }
                if (rdSanction05.Checked)
                {
                    etatSanction = "EtatSanction05";
                }
                if (rdSanction06.Checked)
                {
                    etatSanction = "EtatSanction06";
                }
                if (rdSanction07.Checked)
                {
                    etatSanction = "EtatSanction07";
                }
                if (rdSanction08.Checked)
                {
                    etatSanction = "EtatSanction08";
                }
            }


            if(etatSanction.Equals(""))
            {
                d.ExecuteRequete("exec ajouterAbsNonJustNormal '" + Controle.CefStagiaire + "','" + DtAbss.Value.ToString() + "', 'Absence Non Justifier'");
            }
            else
            {
                d.ExecuteRequete("exec ajouterAbsNonJustSanction '" + Controle.CefStagiaire + "','" + DtAbss.Value.ToString() + "', 'Absence Non Justifier','" + etatSanction + "'");
            }
            MessageBox.Show("Opération terminée avec succés");
            this.AbsNonJustControl_Load(sender, e);

        }



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            d.vidder(this);
            d.vidder(this.gbSanctions);
        }
    }
}
