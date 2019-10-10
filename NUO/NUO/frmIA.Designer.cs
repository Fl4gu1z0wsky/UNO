namespace NUO
{
    partial class frmIA
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
            this.cmdValidation = new System.Windows.Forms.Button();
            this.cboNumberIA = new System.Windows.Forms.ComboBox();
            this.lblChooseNumberIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdValidation
            // 
            this.cmdValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdValidation.Location = new System.Drawing.Point(339, 78);
            this.cmdValidation.Name = "cmdValidation";
            this.cmdValidation.Size = new System.Drawing.Size(121, 43);
            this.cmdValidation.TabIndex = 5;
            this.cmdValidation.Text = "Valider";
            this.cmdValidation.UseVisualStyleBackColor = true;
            this.cmdValidation.Click += new System.EventHandler(this.cmdValidation_Click_1);
            // 
            // cboNumberIA
            // 
            this.cboNumberIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumberIA.FormattingEnabled = true;
            this.cboNumberIA.Location = new System.Drawing.Point(428, 35);
            this.cboNumberIA.Name = "cboNumberIA";
            this.cboNumberIA.Size = new System.Drawing.Size(32, 21);
            this.cboNumberIA.TabIndex = 4;
            // 
            // lblChooseNumberIA
            // 
            this.lblChooseNumberIA.AutoSize = true;
            this.lblChooseNumberIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseNumberIA.Location = new System.Drawing.Point(29, 32);
            this.lblChooseNumberIA.Name = "lblChooseNumberIA";
            this.lblChooseNumberIA.Size = new System.Drawing.Size(378, 24);
            this.lblChooseNumberIA.TabIndex = 3;
            this.lblChooseNumberIA.Text = "Veuillez choisir le nombre d\'adversaires (IA)";
            // 
            // frmIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 143);
            this.Controls.Add(this.cmdValidation);
            this.Controls.Add(this.cboNumberIA);
            this.Controls.Add(this.lblChooseNumberIA);
            this.Name = "frmIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdValidation;
        private System.Windows.Forms.ComboBox cboNumberIA;
        private System.Windows.Forms.Label lblChooseNumberIA;
    }
}