using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfpptAbsence
{
    public class Controle
    {
        Ado d = new Ado();
        public static string CefStagiaire, NomStagiaire, PrenomStagiaire, GroupStagiaire, CinStagiaire, NomUtilisateur,TypeUtilisateur,GroupSelect;
        public static TableLayoutPanel currentPanel;
        public static UserControl UserControl;

        public String Athentification(String login,String password)
        {
            TypeUtilisateur = "";
            d.Connecter();
            d.cmd = new SqlCommand("select * from Utilisateur where login='" + login + "'and Password='" + password + "'", d.cn);
            d.dr = d.cmd.ExecuteReader();

            if (d.dr.HasRows)
            {
                while (d.dr.Read())
                {                    
                    TypeUtilisateur = d.dr[3].ToString();
                    NomUtilisateur = d.dr[0].ToString();                   
                }

            }         
            d.Deconnecter();
            return Controle.TypeUtilisateur;
        }


        public void AfficherControleur(UserControl control, TableLayoutPanel p)
        {
            control.Height = p.Height;
            control.Width = p.Width;
            p.Controls.Clear();
            p.Controls.Add(control);
            control.Show();
        }
        public void AfficherControleur(UserControl control, Panel p)
        {
            control.Height = p.Height;
            control.Width = p.Width;
            p.Controls.Clear();
            p.Controls.Add(control);
            control.Show();
        }

        public void EnabledRadio(GroupBox f,Boolean trfs)
        {
            foreach (Control control in f.Controls)
            {              
                if (control is RadioButton)
                {
                    ((RadioButton)control).Enabled = trfs;
                }
            }
        }

        public void AdabteControle(UserControl userControl,TableLayoutPanel TableLayout)
        {
            userControl.Height = TableLayout.Height;
            userControl.Width = TableLayout.Width;

        }

        public void AdabteControle2(UserControl userControl, TableLayoutPanel TableLayout)
        {
            userControl.Height = TableLayout.Height;
            userControl.Width = TableLayout.Width;
        }
    }
}
