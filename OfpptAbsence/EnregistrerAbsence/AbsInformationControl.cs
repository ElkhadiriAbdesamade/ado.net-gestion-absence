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
    public partial class AbsInformationControl : UserControl
    {
        Ado d = new Ado();
        public AbsInformationControl()
        {
            InitializeComponent();
        }

        private void AbsInformationControl1_Load(object sender, EventArgs e)
        {
            d.Connecter();
            // replir les nombre des abss
            {
                d.cmd = new SqlCommand("select * from stagiaire Where cefstagiaire = '" + Controle.CefStagiaire + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.HasRows)
                {
                    while (d.dr.Read())
                    {
                        int nbrAbss = 0;
                        this.lblAnsNonJust.Text = d.dr[6].ToString();
                        this.lblNbrAbsJust.Text = d.dr[5].ToString();
                        this.lblNbrRetard.Text = d.dr[7].ToString();
                        nbrAbss = (int.Parse(d.dr[6].ToString()) + int.Parse(d.dr[5].ToString()));                        
                        if (nbrAbss == 0)
                            nbrAbss = 1;
                        this.bunifuCircleProgressbar1.MaxValue = nbrAbss;
                        this.bunifuCircleProgressbar1.Value = int.Parse(d.dr[6].ToString());
                    }
                }
                d.dr.Close();
            }

            // remplir list 1

            {
                d.cmd = new SqlCommand("select DocumentDeJustification,dateAbss from absence where typeabss='Absence Justifier' and CefStagiaire='" + Controle.CefStagiaire + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                while (d.dr.Read())
                {
                    lbJus.Items.Add("  *  " + d.dr[0].ToString() + " ==> En La Date : " + ((DateTime)d.dr[1]).ToShortDateString());
                }
                d.dr.Close();
            }

            // remplir list 2

            {
                d.cmd = new SqlCommand("select EtatSanction01,EtatSanction02,EtatSanction03,EtatSanction04,EtatSanction05,EtatSanction06,EtatSanction07,EtatSanction08,dateAbss from absence where cefstagiaire='" + Controle.CefStagiaire + "'", d.cn);
                d.dr = d.cmd.ExecuteReader();
                while (d.dr.Read())
                {                  
                    if (d.dr[0].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "1 ére Mise en garde" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[1].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "2 éme Mise en garde" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[2].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "1 ére avertissement  " + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[3].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "2 éme avertissement  " + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[4].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "Blâme" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[5].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "Exclusion de 2 jours" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[6].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "Exclusion temporaire" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                    if (d.dr[6].ToString() == "1")
                    {
                        lbNonJus.Items.Add("  *  " + "Exclusion temporaire" + " ==> En La Date : " + ((DateTime)d.dr[8]).ToShortDateString());
                    }
                }
                d.dr.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
