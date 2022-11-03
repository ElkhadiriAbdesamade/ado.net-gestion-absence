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
    public partial class RetardControl : UserControl
    {
        Ado d = new Ado();
        public RetardControl()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            d.ExecuteRequete("insert into absence(cefstagiaire,dateAbss,typeabss) values('" + Controle.CefStagiaire + "','" + DtAbss.Value.ToString() + "','Retard')");
            MessageBox.Show("Opération terminée avec succés");
        }

        private void RetardControl_Load(object sender, EventArgs e)
        {
            d.Connecter();
            this.DtAbss.Value = DateTime.Now;
        }
    }
}
