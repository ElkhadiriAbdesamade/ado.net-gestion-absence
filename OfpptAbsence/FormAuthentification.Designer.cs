namespace OfpptAbsence
{
    partial class FormAuthentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentification));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.ckPassword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(133, 268);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(267, 27);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Login";
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
            this.txtUser.MouseHover += new System.EventHandler(this.txtUser_MouseHover);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUser.Location = new System.Drawing.Point(91, 301);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(310, 4);
            this.panelUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(133, 350);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mot de passe";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPassword.Location = new System.Drawing.Point(91, 382);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(310, 4);
            this.panelPassword.TabIndex = 2;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(229)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.btnSignIn.Location = new System.Drawing.Point(118, 483);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(240, 49);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Se connecter";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // ckPassword
            // 
            this.ckPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckPassword.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckPassword.Checked = false;
            this.ckPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckPassword.ForeColor = System.Drawing.Color.White;
            this.ckPassword.Location = new System.Drawing.Point(103, 410);
            this.ckPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckPassword.Name = "ckPassword";
            this.ckPassword.Size = new System.Drawing.Size(20, 20);
            this.ckPassword.TabIndex = 3;
            this.ckPassword.OnChange += new System.EventHandler(this.ckPassword_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(133, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Afficher mot de passe";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(229)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(118, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassword.BackgroundImage")));
            this.picPassword.Location = new System.Drawing.Point(89, 345);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(35, 35);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 0;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.Location = new System.Drawing.Point(89, 263);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 35);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(143, 73);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(204, 133);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // FormAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(66)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(485, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FormUser_Activated);
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picUser;
        private Bunifu.Framework.UI.BunifuCheckbox ckPassword;
        private System.Windows.Forms.Label label1;
    }
}