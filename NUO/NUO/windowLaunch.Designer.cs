namespace NUO
{
    partial class windowLaunch
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowLaunch));
            this.lblCreateurs = new System.Windows.Forms.Label();
            this.lblFlavio = new System.Windows.Forms.Label();
            this.lblMauricio = new System.Windows.Forms.Label();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.cmdValPseudo = new System.Windows.Forms.Button();
            this.txtBoxPseudo = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblBvn = new System.Windows.Forms.Label();
            this.picNUO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateurs
            // 
            this.lblCreateurs.AutoSize = true;
            this.lblCreateurs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreateurs.Font = new System.Drawing.Font("Comfortaa", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateurs.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCreateurs.Location = new System.Drawing.Point(847, 495);
            this.lblCreateurs.Name = "lblCreateurs";
            this.lblCreateurs.Size = new System.Drawing.Size(297, 60);
            this.lblCreateurs.TabIndex = 2;
            this.lblCreateurs.Text = "Les Créateurs";
            // 
            // lblFlavio
            // 
            this.lblFlavio.AutoSize = true;
            this.lblFlavio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFlavio.Font = new System.Drawing.Font("Comfortaa", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFlavio.Location = new System.Drawing.Point(824, 615);
            this.lblFlavio.Name = "lblFlavio";
            this.lblFlavio.Size = new System.Drawing.Size(320, 60);
            this.lblFlavio.TabIndex = 3;
            this.lblFlavio.Text = "Flavio SOVILLA";
            // 
            // lblMauricio
            // 
            this.lblMauricio.AutoSize = true;
            this.lblMauricio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMauricio.Font = new System.Drawing.Font("Comfortaa", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMauricio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMauricio.Location = new System.Drawing.Point(760, 555);
            this.lblMauricio.Name = "lblMauricio";
            this.lblMauricio.Size = new System.Drawing.Size(465, 60);
            this.lblMauricio.TabIndex = 4;
            this.lblMauricio.Text = "Mauricio Costa Cabral";
            // 
            // lblCPNV
            // 
            this.lblCPNV.AutoSize = true;
            this.lblCPNV.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPNV.Font = new System.Drawing.Font("Comfortaa", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNV.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCPNV.Location = new System.Drawing.Point(921, 675);
            this.lblCPNV.Name = "lblCPNV";
            this.lblCPNV.Size = new System.Drawing.Size(135, 60);
            this.lblCPNV.TabIndex = 5;
            this.lblCPNV.Text = "CPNV";
            // 
            // cmdValPseudo
            // 
            this.cmdValPseudo.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdValPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdValPseudo.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValPseudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdValPseudo.Location = new System.Drawing.Point(901, 890);
            this.cmdValPseudo.Name = "cmdValPseudo";
            this.cmdValPseudo.Size = new System.Drawing.Size(142, 41);
            this.cmdValPseudo.TabIndex = 8;
            this.cmdValPseudo.Text = "VALIDER";
            this.cmdValPseudo.UseVisualStyleBackColor = false;
            this.cmdValPseudo.Click += new System.EventHandler(this.cmdValPseudo_Click);
            // 
            // txtBoxPseudo
            // 
            this.txtBoxPseudo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxPseudo.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPseudo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxPseudo.Location = new System.Drawing.Point(820, 827);
            this.txtBoxPseudo.Name = "txtBoxPseudo";
            this.txtBoxPseudo.Size = new System.Drawing.Size(303, 38);
            this.txtBoxPseudo.TabIndex = 7;
            this.txtBoxPseudo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPseudo_KeyDown);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPseudo.Location = new System.Drawing.Point(794, 762);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(366, 39);
            this.lblPseudo.TabIndex = 6;
            this.lblPseudo.Text = "Veuillez insérer un pseudo : ";
            // 
            // lblBvn
            // 
            this.lblBvn.AutoSize = true;
            this.lblBvn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBvn.Font = new System.Drawing.Font("Comfortaa", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBvn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBvn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBvn.Location = new System.Drawing.Point(344, -1);
            this.lblBvn.Name = "lblBvn";
            this.lblBvn.Size = new System.Drawing.Size(1331, 130);
            this.lblBvn.TabIndex = 1;
            this.lblBvn.Text = "Bienvenue dans le jeu du NUO";
            this.lblBvn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picNUO
            // 
            this.picNUO.Image = ((System.Drawing.Image)(resources.GetObject("picNUO.Image")));
            this.picNUO.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNUO.InitialImage")));
            this.picNUO.Location = new System.Drawing.Point(790, 128);
            this.picNUO.Name = "picNUO";
            this.picNUO.Size = new System.Drawing.Size(415, 348);
            this.picNUO.TabIndex = 9;
            this.picNUO.TabStop = false;
            // 
            // windowLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.picNUO);
            this.Controls.Add(this.cmdValPseudo);
            this.Controls.Add(this.txtBoxPseudo);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.lblMauricio);
            this.Controls.Add(this.lblFlavio);
            this.Controls.Add(this.lblCreateurs);
            this.Controls.Add(this.lblBvn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "windowLaunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUO";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreateurs;
        private System.Windows.Forms.Label lblFlavio;
        private System.Windows.Forms.Label lblMauricio;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.Button cmdValPseudo;
        private System.Windows.Forms.TextBox txtBoxPseudo;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.PictureBox picNUO;
    }
}

