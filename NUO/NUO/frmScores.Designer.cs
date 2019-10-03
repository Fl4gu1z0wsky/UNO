namespace NUO
{
    partial class frmScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScores));
            this.lblScores = new System.Windows.Forms.Label();
            this.picNUO = new System.Windows.Forms.PictureBox();
            this.lblCPNV = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScores.Location = new System.Drawing.Point(713, 87);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(244, 78);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "SCORES";
            // 
            // picNUO
            // 
            this.picNUO.Image = ((System.Drawing.Image)(resources.GetObject("picNUO.Image")));
            this.picNUO.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNUO.InitialImage")));
            this.picNUO.Location = new System.Drawing.Point(67, 34);
            this.picNUO.Name = "picNUO";
            this.picNUO.Size = new System.Drawing.Size(424, 343);
            this.picNUO.TabIndex = 12;
            this.picNUO.TabStop = false;
            // 
            // lblCPNV
            // 
            this.lblCPNV.AutoSize = true;
            this.lblCPNV.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPNV.Location = new System.Drawing.Point(777, 959);
            this.lblCPNV.Name = "lblCPNV";
            this.lblCPNV.Size = new System.Drawing.Size(504, 44);
            this.lblCPNV.TabIndex = 20;
            this.lblCPNV.Text = "CPNV Ste-Croix - Projet en binôme";
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.SystemColors.InfoText;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBack.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdBack.Location = new System.Drawing.Point(757, 822);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(476, 50);
            this.cmdBack.TabIndex = 19;
            this.cmdBack.Text = "Retour au menu des règles";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblCPNV);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.picNUO);
            this.Controls.Add(this.lblScores);
            this.Name = "frmScores";
            this.Text = "NUO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNUO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.PictureBox picNUO;
        private System.Windows.Forms.Label lblCPNV;
        private System.Windows.Forms.Button cmdBack;
    }
}