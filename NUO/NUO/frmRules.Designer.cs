namespace NUO
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.picNUO = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdJoker = new System.Windows.Forms.Button();
            this.cmdCards = new System.Windows.Forms.Button();
            this.cmdPurpose = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.cmdRules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // picNUO
            // 
            this.picNUO.Image = ((System.Drawing.Image)(resources.GetObject("picNUO.Image")));
            this.picNUO.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNUO.InitialImage")));
            this.picNUO.Location = new System.Drawing.Point(67, 34);
            this.picNUO.Name = "picNUO";
            this.picNUO.Size = new System.Drawing.Size(415, 348);
            this.picNUO.TabIndex = 10;
            this.picNUO.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(655, 173);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 78);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Règles du jeu";
            // 
            // cmdJoker
            // 
            this.cmdJoker.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdJoker.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdJoker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdJoker.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJoker.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdJoker.Location = new System.Drawing.Point(668, 493);
            this.cmdJoker.Name = "cmdJoker";
            this.cmdJoker.Size = new System.Drawing.Size(316, 50);
            this.cmdJoker.TabIndex = 14;
            this.cmdJoker.Text = "Les cartes joker";
            this.cmdJoker.UseVisualStyleBackColor = false;
            this.cmdJoker.Click += new System.EventHandler(this.cmdJoker_Click);
            // 
            // cmdCards
            // 
            this.cmdCards.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdCards.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCards.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCards.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdCards.Location = new System.Drawing.Point(646, 400);
            this.cmdCards.Name = "cmdCards";
            this.cmdCards.Size = new System.Drawing.Size(372, 50);
            this.cmdCards.TabIndex = 13;
            this.cmdCards.Text = "Les différentes cartes";
            this.cmdCards.UseVisualStyleBackColor = false;
            this.cmdCards.Click += new System.EventHandler(this.cmdCards_Click);
            // 
            // cmdPurpose
            // 
            this.cmdPurpose.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdPurpose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPurpose.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPurpose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdPurpose.Location = new System.Drawing.Point(668, 311);
            this.cmdPurpose.Name = "cmdPurpose";
            this.cmdPurpose.Size = new System.Drawing.Size(316, 50);
            this.cmdPurpose.TabIndex = 15;
            this.cmdPurpose.Text = "Le but du jeu";
            this.cmdPurpose.UseVisualStyleBackColor = false;
            this.cmdPurpose.Click += new System.EventHandler(this.cmdPurpose_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBack.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdBack.Location = new System.Drawing.Point(668, 822);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(316, 50);
            this.cmdBack.TabIndex = 16;
            this.cmdBack.Text = "Retour au menu";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblCPNV
            // 
            this.lblCPNV.AutoSize = true;
            this.lblCPNV.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPNV.Location = new System.Drawing.Point(555, 959);
            this.lblCPNV.Name = "lblCPNV";
            this.lblCPNV.Size = new System.Drawing.Size(504, 44);
            this.lblCPNV.TabIndex = 17;
            this.lblCPNV.Text = "CPNV Ste-Croix - Projet en binôme";
            // 
            // cmdRules
            // 
            this.cmdRules.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdRules.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRules.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRules.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdRules.Location = new System.Drawing.Point(668, 581);
            this.cmdRules.Name = "cmdRules";
            this.cmdRules.Size = new System.Drawing.Size(316, 50);
            this.cmdRules.TabIndex = 18;
            this.cmdRules.Text = "Les règles du jeu";
            this.cmdRules.UseVisualStyleBackColor = false;
            this.cmdRules.Click += new System.EventHandler(this.cmdRules_Click);
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cmdRules);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdPurpose);
            this.Controls.Add(this.cmdJoker);
            this.Controls.Add(this.cmdCards);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picNUO);
            this.Name = "frmRules";
            this.Text = "frmRules";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNUO;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdJoker;
        private System.Windows.Forms.Button cmdCards;
        private System.Windows.Forms.Button cmdPurpose;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.Button cmdRules;
    }
}