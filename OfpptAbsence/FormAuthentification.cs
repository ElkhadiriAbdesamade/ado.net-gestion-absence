using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfpptAbsence
{
    public partial class FormAuthentification : Form
    {
        Controle c = new Controle();

        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            
        }

       





        private void btnClose_Click(object sender, EventArgs e)
        {          
            Application.Exit();
        }

        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            //Designe
            if (this.txtUser.Text.Equals(""))
            {
                
                    this.txtUser.Text = "Login";
                    this.picUser.BackgroundImage = Properties.Resources.user_male2_30px;
                    this.panelUser.ForeColor = Color.WhiteSmoke;
                    this.txtUser.ForeColor = Color.WhiteSmoke;             
            }
            this.ActiveControl = null;

        }

        private void txtUser_MouseHover(object sender, EventArgs e)
        {
            //Designe
            this.txtUser.Focus();
            if(this.txtUser.Text.Equals("Login"))
            {
                this.txtUser.Clear();
                this.picUser.BackgroundImage = Properties.Resources.user_male_30px;
                this.panelUser.ForeColor = Color.FromArgb(87, 192, 229);
                this.txtUser.ForeColor = Color.FromArgb(87, 192, 229);

                this.picPassword.BackgroundImage = Properties.Resources.lock2_30px;
                this.panelPassword.ForeColor = Color.WhiteSmoke;
                this.txtPassword.ForeColor = Color.WhiteSmoke;
            }
           
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            //Designe
            this.txtPassword.Focus();
            if(this.txtPassword.Text.Equals("Mot de passe"))
            {
                this.txtPassword.Clear();
                this.txtPassword.UseSystemPasswordChar = true;
                this.picPassword.BackgroundImage = Properties.Resources.lock_30px;
                this.panelPassword.ForeColor = Color.FromArgb(87, 192, 229);
                this.txtPassword.ForeColor = Color.FromArgb(87, 192, 229);

                this.picUser.BackgroundImage = Properties.Resources.user_male2_30px;
                this.panelUser.ForeColor = Color.WhiteSmoke;
                this.txtUser.ForeColor = Color.WhiteSmoke;
            }
            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            //Designe
            if (this.txtPassword.Text.Equals(""))
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Mot de passe";
                this.picPassword.BackgroundImage = Properties.Resources.lock2_30px;
                this.panelPassword.ForeColor = Color.WhiteSmoke;
                this.txtPassword.ForeColor = Color.WhiteSmoke;
            }
            this.ActiveControl = null;
        }

        private void FormUser_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        

        private void ckPassword_OnChange(object sender, EventArgs e)
        {
            //Designe
            if (this.ckPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (! this.txtPassword.Text.Equals("Mot de passe"))
                {
                    this.txtPassword.UseSystemPasswordChar = true;
                }
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string type=c.Athentification(this.txtUser.Text,this.txtPassword.Text);

            
            if (type == "Utilisateur standard" || type == "Administrateur")
            {
                FormUtilisateur utilisateur = new FormUtilisateur();
                utilisateur.Show();
                this.Hide();
            }
             else
                 {
                    MessageBox.Show("Login Ou Mote de Pass Est Incorrect !!");
                   this.txtPassword.Clear();
                   this.txtPassword.Focus();
                 }
        }

    }
}
