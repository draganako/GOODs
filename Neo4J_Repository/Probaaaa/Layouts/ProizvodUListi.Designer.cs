namespace Probaaaa.Layouts
{
    partial class ProizvodUListi
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
            this.pbProizvod = new System.Windows.Forms.PictureBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProizvod
            // 
            this.pbProizvod.Location = new System.Drawing.Point(38, 12);
            this.pbProizvod.Name = "pbProizvod";
            this.pbProizvod.Size = new System.Drawing.Size(127, 136);
            this.pbProizvod.TabIndex = 0;
            this.pbProizvod.TabStop = false;
            this.pbProizvod.Click += new System.EventHandler(this.pbProizvod_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(52, 198);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(86, 10);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Details";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Visible = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(35, 151);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 17);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "label1";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(35, 168);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(46, 17);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "label1";
            // 
            // ProizvodUListi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.pbProizvod);
            this.Name = "ProizvodUListi";
            this.Size = new System.Drawing.Size(200, 224);
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProizvod;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCena;
    }
}
