namespace NUO
{
    partial class frmLaunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaunch));
            this.lblCreators = new System.Windows.Forms.Label();
            this.lblFlavio = new System.Windows.Forms.Label();
            this.lblMauricio = new System.Windows.Forms.Label();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.cmdVal = new System.Windows.Forms.Button();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picNUO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreators
            // 
            this.lblCreators.AutoSize = true;
            this.lblCreators.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreators.Font = new System.Drawing.Font("Comfortaa", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreators.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCreators.Location = new System.Drawing.Point(847, 495);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(297, 60);
            this.lblCreators.TabIndex = 2;
            this.lblCreators.Text = "Les Créateurs";
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
            // cmdVal
            // 
            this.cmdVal.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdVal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdVal.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdVal.Location = new System.Drawing.Point(901, 890);
            this.cmdVal.Name = "cmdVal";
            this.cmdVal.Size = new System.Drawing.Size(142, 41);
            this.cmdVal.TabIndex = 8;
            this.cmdVal.Text = "VALIDER";
            this.cmdVal.UseVisualStyleBackColor = false;
            this.cmdVal.Click += new System.EventHandler(this.cmdVal_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPseudo.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPseudo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPseudo.Location = new System.Drawing.Point(820, 827);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(303, 38);
            this.txtPseudo.TabIndex = 7;
            this.txtPseudo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPseudo_KeyDown);
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Font = new System.Drawing.Font("Comfortaa", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(344, -1);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1331, 130);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Bienvenue dans le jeu du NUO";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // frmLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.picNUO);
            this.Controls.Add(this.cmdVal);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.lblMauricio);
            this.Controls.Add(this.lblFlavio);
            this.Controls.Add(this.lblCreators);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLaunch";
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
        private System.Windows.Forms.Label lblCreators;
        private System.Windows.Forms.Label lblFlavio;
        private System.Windows.Forms.Label lblMauricio;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.Button cmdVal;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picNUO;
    }
}

