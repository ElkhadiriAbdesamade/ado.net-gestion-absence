using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Bunifu.Framework.UI;

namespace OfpptAbsence
{
    class Ado
    {
        
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void Connecter()
        {
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn = new SqlConnection("Initial Catalog=OfpptAbsence;Integrated Security=True");
                cn.Open();
            }
        }

        //internal void remplireCombobox(string v, BunifuDropdown cmbGroup)
        //{
        //    throw new NotImplementedException();
        //}
        public Boolean testvide(UserControl f)
        {
            Boolean b = true;
            foreach (Control c in f.Controls)
            {
                if (c is BunifuMetroTextbox)
                {
                    if (c.Text.Equals(""))
                    {
                        MessageBox.Show("Contenu incorrect ");
                        c.Focus();
                        b = false;
                        return b;
                    }
                }
                if (c is ComboBox)
                {
                    if (c.Text.Equals(""))
                    {
                        MessageBox.Show("Contenu incorrect ");
                        c.Focus();
                        b = false;
                        return b;
                    }
                }
            }
            return b;
        }

        public Boolean testvide(TableLayoutPanel f)
        {
            Boolean b = true;
            foreach (Control c in f.Controls)
            {
                if (c is BunifuMetroTextbox)
                {
                    if (c.Text.Equals(""))
                    {
                        MessageBox.Show("Contenu incorrect ");
                        c.Focus();
                        b = false;
                        return b;
                    }
                }
                if (c is ComboBox)
                {
                    if (c.Text.Equals(""))
                    {
                        MessageBox.Show("Contenu incorrect ");
                        c.Focus();
                        b = false;
                        return b;
                    }
                }
            }
            return b;
        }

        public void Deconnecter()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public void ExecuteRequete(string req)
        {
            cmd = new SqlCommand(req, cn);
            cmd.ExecuteNonQuery();
        }
        public void remplireCombobox(string req, ComboBox cb)
        {
            cmd = new SqlCommand(req, cn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {                
                    cb.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            dr.Close();
        }
        public void remplireDataGridView(string req, DataGridView dg)
        {
            if (dt.Rows.Count != 0)
            {
                dt.Rows.Clear();
            }
            cmd = new SqlCommand(req, cn);
            dr = cmd.ExecuteReader();

            dt.Load(dr);
            dg.DataSource = dt;
            dr.Close();
        }

        public void vidder(Form f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is BunifuMetroTextbox)
                {
                    ((BunifuMetroTextbox)control).Text = "";
                }

                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }

            }
        }
        public void vidder(GroupBox f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is BunifuMetroTextbox)
                {
                    ((BunifuMetroTextbox)control).Text = "";
                }

                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }
        public void vidder(UserControl f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is BunifuMetroTextbox)
                {
                    ((BunifuMetroTextbox)control).Text = "";
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }

            }
        }

        public void vidder(TableLayoutPanel f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is BunifuMetroTextbox)
                {
                    ((BunifuMetroTextbox)control).Text = "";
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }

            }
        }


    }
}
