namespace Probaaaa.Layouts
{
    partial class ProizvodLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.tbxOpis = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPicture
            // 
            this.pbxPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxPicture.Location = new System.Drawing.Point(15, 23);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(59, 51);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture.TabIndex = 0;
            this.pbxPicture.TabStop = false;
            // 
            // tbxOpis
            // 
            this.tbxOpis.Enabled = false;
            this.tbxOpis.Location = new System.Drawing.Point(15, 138);
            this.tbxOpis.Multiline = true;
            this.tbxOpis.Name = "tbxOpis";
            this.tbxOpis.Size = new System.Drawing.Size(161, 43);
            this.tbxOpis.TabIndex = 1;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(80, 74);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(49, 17);
            this.lblCena.TabIndex = 2;
            this.lblCena.Text = "Cena: ";
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(80, 91);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(58, 17);
            this.lblOcena.TabIndex = 3;
            this.lblOcena.Text = "Ocena: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naziv: ";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(80, 57);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(85, 17);
            this.lblProizvodjac.TabIndex = 5;
            this.lblProizvodjac.Text = "Proizvodjac:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(12, 118);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 17);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(80, 40);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(36, 17);
            this.lblTip.TabIndex = 7;
            this.lblTip.Text = "Tip: ";
            // 
            // ProizvodLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.tbxOpis);
            this.Controls.Add(this.pbxPicture);
            this.Name = "ProizvodLayout";
            this.Size = new System.Drawing.Size(198, 191);
            this.Load += new System.EventHandler(this.ProizvodLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.TextBox tbxOpis;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblTip;
    }
}
