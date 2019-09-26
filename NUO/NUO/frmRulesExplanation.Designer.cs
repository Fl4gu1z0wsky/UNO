namespace NUO
{
    partial class frmRulesExplanation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRulesExplanation));
            this.picNUO = new System.Windows.Forms.PictureBox();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // picNUO
            // 
            this.picNUO.Image = ((System.Drawing.Image)(resources.GetObject("picNUO.Image")));
            this.picNUO.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNUO.InitialImage")));
            this.picNUO.Location = new System.Drawing.Point(67, 681);
            this.picNUO.Name = "picNUO";
            this.picNUO.Size = new System.Drawing.Size(415, 348);
            this.picNUO.TabIndex = 11;
            this.picNUO.TabStop = false;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBack.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdBack.Location = new System.Drawing.Point(714, 822);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(476, 50);
            this.cmdBack.TabIndex = 19;
            this.cmdBack.Text = "Retour au menu des règles";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblCPNV
            // 
            this.lblCPNV.AutoSize = true;
            this.lblCPNV.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPNV.Location = new System.Drawing.Point(700, 959);
            this.lblCPNV.Name = "lblCPNV";
            this.lblCPNV.Size = new System.Drawing.Size(504, 44);
            this.lblCPNV.TabIndex = 20;
            this.lblCPNV.Text = "CPNV Ste-Croix - Projet en binôme";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRules.Location = new System.Drawing.Point(518, 95);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(1316, 578);
            this.lblRules.TabIndex = 21;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // frmRulesExplanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.picNUO);
            this.Name = "frmRulesExplanation";
            this.Text = "frmRulesExplanation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRulesExplanation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNUO;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.Label lblRules;
    }
}