namespace NUO
{
    partial class windowWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowWelcome));
            this.lblBvn = new System.Windows.Forms.Label();
            this.cmdPartie = new System.Windows.Forms.Button();
            this.cmdScores = new System.Windows.Forms.Button();
            this.cmdRegles = new System.Windows.Forms.Button();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.picNUO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBvn
            // 
            this.lblBvn.AutoSize = true;
            this.lblBvn.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBvn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBvn.Location = new System.Drawing.Point(804, 416);
            this.lblBvn.Name = "lblBvn";
            this.lblBvn.Size = new System.Drawing.Size(296, 78);
            this.lblBvn.TabIndex = 0;
            this.lblBvn.Text = "Bienvenue";
            // 
            // cmdPartie
            // 
            this.cmdPartie.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdPartie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdPartie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPartie.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPartie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdPartie.Location = new System.Drawing.Point(784, 544);
            this.cmdPartie.Name = "cmdPartie";
            this.cmdPartie.Size = new System.Drawing.Size(316, 50);
            this.cmdPartie.TabIndex = 1;
            this.cmdPartie.Text = "Lancer la partie";
            this.cmdPartie.UseVisualStyleBackColor = false;
            // 
            // cmdScores
            // 
            this.cmdScores.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdScores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdScores.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdScores.Location = new System.Drawing.Point(784, 632);
            this.cmdScores.Name = "cmdScores";
            this.cmdScores.Size = new System.Drawing.Size(316, 50);
            this.cmdScores.TabIndex = 2;
            this.cmdScores.Text = "TOP 10 des scores";
            this.cmdScores.UseVisualStyleBackColor = false;
            // 
            // cmdRegles
            // 
            this.cmdRegles.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdRegles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdRegles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegles.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegles.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdRegles.Location = new System.Drawing.Point(784, 720);
            this.cmdRegles.Name = "cmdRegles";
            this.cmdRegles.Size = new System.Drawing.Size(316, 50);
            this.cmdRegles.TabIndex = 3;
            this.cmdRegles.Text = "Règles du jeu";
            this.cmdRegles.UseVisualStyleBackColor = false;
            // 
            // lblCPNV
            // 
            this.lblCPNV.AutoSize = true;
            this.lblCPNV.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPNV.Location = new System.Drawing.Point(692, 918);
            this.lblCPNV.Name = "lblCPNV";
            this.lblCPNV.Size = new System.Drawing.Size(504, 44);
            this.lblCPNV.TabIndex = 4;
            this.lblCPNV.Text = "CPNV Ste-Croix - Projet en binôme";
            // 
            // picNUO
            // 
            this.picNUO.Image = ((System.Drawing.Image)(resources.GetObject("picNUO.Image")));
            this.picNUO.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNUO.InitialImage")));
            this.picNUO.Location = new System.Drawing.Point(749, 12);
            this.picNUO.Name = "picNUO";
            this.picNUO.Size = new System.Drawing.Size(415, 349);
            this.picNUO.TabIndex = 6;
            this.picNUO.TabStop = false;
            // 
            // windowWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.picNUO);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.cmdRegles);
            this.Controls.Add(this.cmdScores);
            this.Controls.Add(this.cmdPartie);
            this.Controls.Add(this.lblBvn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "windowWelcome";
            this.Text = "NUO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.windowWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.Button cmdPartie;
        private System.Windows.Forms.Button cmdScores;
        private System.Windows.Forms.Button cmdRegles;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.PictureBox picNUO;
    }
}