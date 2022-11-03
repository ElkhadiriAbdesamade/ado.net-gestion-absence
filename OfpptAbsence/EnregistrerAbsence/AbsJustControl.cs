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
    public partial class AbsJustControl : UserControl
    {
        Ado d = new Ado();
        public AbsJustControl()
        {
            InitializeComponent();
        }

        private void AbsJustControl_Load(object sender, EventArgs e)
        {
            d.Connecter();
            this.DtAbss.Value = DateTime.Now;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            d.vidder(this);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            d.ExecuteRequete("insert into absence values('" + Controle.CefStagiaire + "','" + DtAbss.Value.ToString() + "','Absence Justifier','" + this.txtDocument.Text + "',0,0,0,0,0,0,0,0)");
            MessageBox.Show("Opération terminée avec succés");
            d.vidder(this);
        }
    }
}
