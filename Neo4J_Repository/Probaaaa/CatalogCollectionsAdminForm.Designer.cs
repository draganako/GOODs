namespace Probaaaa
{
    partial class CatalogCollectionsAdminForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.dgKolekcije = new System.Windows.Forms.DataGridView();
            this.lblKolekcija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKolekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(25, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(159, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New collection";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(813, 463);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(180, 49);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Choose selected";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dgKolekcije
            // 
            this.dgKolekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKolekcije.Location = new System.Drawing.Point(12, 149);
            this.dgKolekcije.Name = "dgKolekcije";
            this.dgKolekcije.RowHeadersWidth = 51;
            this.dgKolekcije.RowTemplate.Height = 24;
            this.dgKolekcije.Size = new System.Drawing.Size(981, 264);
            this.dgKolekcije.TabIndex = 3;
            this.dgKolekcije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKolekcije_CellClick);
            this.dgKolekcije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKolekcije_CellContentClick);
            // 
            // lblKolekcija
            // 
            this.lblKolekcija.AutoSize = true;
            this.lblKolekcija.Location = new System.Drawing.Point(419, 41);
            this.lblKolekcija.Name = "lblKolekcija";
            this.lblKolekcija.Size = new System.Drawing.Size(46, 17);
            this.lblKolekcija.TabIndex = 4;
            this.lblKolekcija.Text = "label1";
            // 
            // CatalogCollectionsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 563);
            this.Controls.Add(this.lblKolekcija);
            this.Controls.Add(this.dgKolekcije);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnNew);
            this.Name = "CatalogCollectionsAdminForm";
            this.Text = "Catalog collections";
            this.Load += new System.EventHandler(this.CollectionAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKolekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dgKolekcije;
        private System.Windows.Forms.Label lblKolekcija;
    }
}