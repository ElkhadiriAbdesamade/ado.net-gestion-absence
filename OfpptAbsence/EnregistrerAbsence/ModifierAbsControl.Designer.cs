namespace OfpptAbsence
{
    partial class ModifierAbsControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEtat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAbsJust = new System.Windows.Forms.Button();
            this.btnAbsNonJust = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAbsNonJust, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAbsJust, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1115, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.39394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.60606F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAbsence,
            this.Cef,
            this.Date,
            this.Type,
            this.Document,
            this.cmbEtat,
            this.Modifier,
            this.Supprimer});
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 334);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdAbsence
            // 
            this.IdAbsence.FillWeight = 21.22412F;
            this.IdAbsence.HeaderText = "Id";
            this.IdAbsence.MinimumWidth = 6;
            this.IdAbsence.Name = "IdAbsence";
            this.IdAbsence.ReadOnly = true;
            // 
            // Cef
            // 
            this.Cef.FillWeight = 82.31989F;
            this.Cef.HeaderText = "Cef Stagiaire";
            this.Cef.MinimumWidth = 6;
            this.Cef.Name = "Cef";
            this.Cef.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 112.2995F;
            this.Date.HeaderText = "Date de l\'absence";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type de l\'absence";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document De Justification";
            this.Document.MinimumWidth = 6;
            this.Document.Name = "Document";
            this.Document.Visible = false;
            // 
            // cmbEtat
            // 
            this.cmbEtat.HeaderText = "Etat Sanction";
            this.cmbEtat.Items.AddRange(new object[] {
            "Aucun",
            "1 éme Mise en garde",
            "2 éme Mise en garde",
            "1 éme avertissement",
            "2 éme avertissement",
            "Blâme",
            "Exclusion de 2 jours",
            "Exclusion temporaire",
            "Exclusion définitive"});
            this.cmbEtat.MinimumWidth = 6;
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Visible = false;
            // 
            // Modifier
            // 
            this.Modifier.FillWeight = 128.0522F;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.FillWeight = 128.0522F;
            this.Supprimer.HeaderText = "Suprimmer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // btnAbsJust
            // 
            this.btnAbsJust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsJust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbsJust.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAbsJust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsJust.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsJust.ForeColor = System.Drawing.Color.LightGray;
            this.btnAbsJust.Location = new System.Drawing.Point(3, 3);
            this.btnAbsJust.Name = "btnAbsJust";
            this.btnAbsJust.Size = new System.Drawing.Size(551, 44);
            this.btnAbsJust.TabIndex = 57;
            this.btnAbsJust.Text = "Absence Justifier";
            this.btnAbsJust.UseVisualStyleBackColor = true;
            this.btnAbsJust.Click += new System.EventHandler(this.btnAbsJust_Click);
            // 
            // btnAbsNonJust
            // 
            this.btnAbsNonJust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsNonJust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbsNonJust.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAbsNonJust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsNonJust.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsNonJust.ForeColor = System.Drawing.Color.LightGray;
            this.btnAbsNonJust.Location = new System.Drawing.Point(560, 3);
            this.btnAbsNonJust.Name = "btnAbsNonJust";
            this.btnAbsNonJust.Size = new System.Drawing.Size(552, 44);
            this.btnAbsNonJust.TabIndex = 58;
            this.btnAbsNonJust.Text = "Absence Non Justifier";
            this.btnAbsNonJust.UseVisualStyleBackColor = true;
            this.btnAbsNonJust.Click += new System.EventHandler(this.btnAbsNonJust_Click);
            // 
            // ModifierAbsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModifierAbsControl";
            this.Size = new System.Drawing.Size(1124, 402);
            this.Load += new System.EventHandler(this.ModifierAbsControl_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAbsNonJust;
        private System.Windows.Forms.Button btnAbsJust;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbEtat;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
