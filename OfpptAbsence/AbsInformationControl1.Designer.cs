namespace OfpptAbsence
{
    partial class AbsInformationControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsInformationControl1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNbrAbsJust = new System.Windows.Forms.Label();
            this.lblNbrRetard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnsNonJust = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNonJus = new System.Windows.Forms.ListBox();
            this.lbJus = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNbrAbsJust);
            this.groupBox1.Controls.Add(this.lblNbrRetard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAnsNonJust);
            this.groupBox1.Controls.Add(this.bunifuCircleProgressbar1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbNonJus);
            this.groupBox1.Controls.Add(this.lbJus);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absence Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(680, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Absence Justifier";
            // 
            // lblNbrAbsJust
            // 
            this.lblNbrAbsJust.AutoSize = true;
            this.lblNbrAbsJust.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrAbsJust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.lblNbrAbsJust.Location = new System.Drawing.Point(476, 75);
            this.lblNbrAbsJust.Name = "lblNbrAbsJust";
            this.lblNbrAbsJust.Size = new System.Drawing.Size(25, 28);
            this.lblNbrAbsJust.TabIndex = 64;
            this.lblNbrAbsJust.Text = "0";
            // 
            // lblNbrRetard
            // 
            this.lblNbrRetard.AutoSize = true;
            this.lblNbrRetard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrRetard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.lblNbrRetard.Location = new System.Drawing.Point(476, 33);
            this.lblNbrRetard.Name = "lblNbrRetard";
            this.lblNbrRetard.Size = new System.Drawing.Size(25, 28);
            this.lblNbrRetard.TabIndex = 62;
            this.lblNbrRetard.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(680, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Absence Non Justifier\r\n";
            // 
            // lblAnsNonJust
            // 
            this.lblAnsNonJust.AutoSize = true;
            this.lblAnsNonJust.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsNonJust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.lblAnsNonJust.Location = new System.Drawing.Point(476, 116);
            this.lblAnsNonJust.Name = "lblAnsNonJust";
            this.lblAnsNonJust.Size = new System.Drawing.Size(25, 28);
            this.lblAnsNonJust.TabIndex = 63;
            this.lblAnsNonJust.Text = "0";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 7;
            this.bunifuCircleProgressbar1.LineThickness = 8;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(908, 18);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuCircleProgressbar1.MaxValue = 1;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(177, 177);
            this.bunifuCircleProgressbar1.TabIndex = 48;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.label11.Location = new System.Drawing.Point(569, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 29);
            this.label11.TabIndex = 47;
            this.label11.Text = "Les Sanctions De L\'absence :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(219)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Document De Justification :";
            // 
            // lbNonJus
            // 
            this.lbNonJus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(152)))));
            this.lbNonJus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNonJus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.lbNonJus.FormattingEnabled = true;
            this.lbNonJus.ItemHeight = 24;
            this.lbNonJus.Location = new System.Drawing.Point(556, 200);
            this.lbNonJus.Name = "lbNonJus";
            this.lbNonJus.Size = new System.Drawing.Size(532, 172);
            this.lbNonJus.TabIndex = 44;
            // 
            // lbJus
            // 
            this.lbJus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(152)))));
            this.lbJus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.lbJus.FormattingEnabled = true;
            this.lbJus.ItemHeight = 24;
            this.lbJus.Location = new System.Drawing.Point(7, 200);
            this.lbJus.Name = "lbJus";
            this.lbJus.Size = new System.Drawing.Size(532, 172);
            this.lbJus.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(70, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(384, 27);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nombre De Absence Non Justifier  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(70, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 27);
            this.label12.TabIndex = 33;
            this.label12.Text = "Nombre De Absence Justifier  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(70, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 27);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nombre De Retard  :";
            // 
            // AbsInformationControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "AbsInformationControl1";
            this.Size = new System.Drawing.Size(1150, 394);
            this.Load += new System.EventHandler(this.AbsInformationControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbNonJus;
        private System.Windows.Forms.ListBox lbJus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNbrAbsJust;
        private System.Windows.Forms.Label lblNbrRetard;
        private System.Windows.Forms.Label lblAnsNonJust;
        private System.Windows.Forms.Label label2;
    }
}
