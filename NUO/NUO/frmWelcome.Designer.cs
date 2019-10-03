namespace NUO
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblBvn = new System.Windows.Forms.Label();
            this.cmdGame = new System.Windows.Forms.Button();
            this.cmdScores = new System.Windows.Forms.Button();
            this.cmdRules = new System.Windows.Forms.Button();
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
            // cmdGame
            // 
            this.cmdGame.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGame.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGame.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdGame.Location = new System.Drawing.Point(784, 544);
            this.cmdGame.Name = "cmdGame";
            this.cmdGame.Size = new System.Drawing.Size(316, 50);
            this.cmdGame.TabIndex = 1;
            this.cmdGame.Text = "Lancer la partie";
            this.cmdGame.UseVisualStyleBackColor = false;
            this.cmdGame.Click += new System.EventHandler(this.cmdGame_Click);
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
            this.cmdScores.Click += new System.EventHandler(this.cmdScores_Click);
            // 
            // cmdRules
            // 
            this.cmdRules.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdRules.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRules.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRules.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdRules.Location = new System.Drawing.Point(784, 720);
            this.cmdRules.Name = "cmdRules";
            this.cmdRules.Size = new System.Drawing.Size(316, 50);
            this.cmdRules.TabIndex = 3;
            this.cmdRules.Text = "Règles du jeu";
            this.cmdRules.UseVisualStyleBackColor = false;
            this.cmdRules.Click += new System.EventHandler(this.cmdRules_Click);
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
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.picNUO);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.cmdRules);
            this.Controls.Add(this.cmdScores);
            this.Controls.Add(this.cmdGame);
            this.Controls.Add(this.lblBvn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmWelcome";
            this.Text = "NUO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.windowWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.Button cmdGame;
        private System.Windows.Forms.Button cmdScores;
        private System.Windows.Forms.Button cmdRules;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.PictureBox picNUO;
    }
}