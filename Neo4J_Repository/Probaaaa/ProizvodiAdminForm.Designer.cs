namespace Probaaaa
{
    partial class ProizvodiAdminForm
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.lblKolekcija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(834, 443);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(162, 42);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Choose selected";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(31, 40);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(159, 31);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New item";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Location = new System.Drawing.Point(15, 161);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.RowHeadersWidth = 51;
            this.dgProizvodi.RowTemplate.Height = 24;
            this.dgProizvodi.Size = new System.Drawing.Size(981, 264);
            this.dgProizvodi.TabIndex = 6;
            this.dgProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProizvodi_CellClick);
            // 
            // lblKolekcija
            // 
            this.lblKolekcija.AutoSize = true;
            this.lblKolekcija.Location = new System.Drawing.Point(426, 47);
            this.lblKolekcija.Name = "lblKolekcija";
            this.lblKolekcija.Size = new System.Drawing.Size(46, 17);
            this.lblKolekcija.TabIndex = 7;
            this.lblKolekcija.Text = "label1";
            // 
            // ProizvodiAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 509);
            this.Controls.Add(this.lblKolekcija);
            this.Controls.Add(this.dgProizvodi);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnNew);
            this.Name = "ProizvodiAdminForm";
            this.Text = "Catalog products";
            this.Load += new System.EventHandler(this.ProizvodiAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Label lblKolekcija;
    }
}