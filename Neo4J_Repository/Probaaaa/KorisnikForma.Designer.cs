namespace Probaaaa
{
    partial class KorisnikForma
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
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.lblImeKol = new System.Windows.Forms.Label();
            this.layout4Products = new Probaaaa.Layouts.Layout4Products();
            this.userControl2 = new Probaaaa.UserControl2();
            this.userControl1 = new Probaaaa.UserControl1();
            this.btnPrevKol = new System.Windows.Forms.Button();
            this.btnNextKol = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.Controls.Add(this.lblImeKol);
            this.gbPrikaz.Controls.Add(this.layout4Products);
            this.gbPrikaz.Controls.Add(this.userControl2);
            this.gbPrikaz.Controls.Add(this.userControl1);
            this.gbPrikaz.Controls.Add(this.btnPrevKol);
            this.gbPrikaz.Controls.Add(this.btnNextKol);
            this.gbPrikaz.Location = new System.Drawing.Point(23, 57);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(974, 545);
            this.gbPrikaz.TabIndex = 1;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Products";
            // 
            // lblImeKol
            // 
            this.lblImeKol.AutoSize = true;
            this.lblImeKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeKol.Location = new System.Drawing.Point(281, 473);
            this.lblImeKol.Name = "lblImeKol";
            this.lblImeKol.Size = new System.Drawing.Size(59, 20);
            this.lblImeKol.TabIndex = 8;
            this.lblImeKol.Text = "label1";
            // 
            // layout4Products
            // 
            this.layout4Products.Location = new System.Drawing.Point(220, 41);
            this.layout4Products.Name = "layout4Products";
            this.layout4Products.Size = new System.Drawing.Size(631, 408);
            this.layout4Products.TabIndex = 7;
            // 
            // userControl2
            // 
            this.userControl2.Location = new System.Drawing.Point(190, 31);
            this.userControl2.Name = "userControl2";
            this.userControl2.Size = new System.Drawing.Size(597, 424);
            this.userControl2.TabIndex = 6;
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(220, 41);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(437, 429);
            this.userControl1.TabIndex = 5;
            // 
            // btnPrevKol
            // 
            this.btnPrevKol.Location = new System.Drawing.Point(17, 168);
            this.btnPrevKol.Name = "btnPrevKol";
            this.btnPrevKol.Size = new System.Drawing.Size(68, 140);
            this.btnPrevKol.TabIndex = 2;
            this.btnPrevKol.Text = "<";
            this.btnPrevKol.UseVisualStyleBackColor = true;
            this.btnPrevKol.Click += new System.EventHandler(this.btnPrevKol_Click);
            // 
            // btnNextKol
            // 
            this.btnNextKol.Location = new System.Drawing.Point(877, 178);
            this.btnNextKol.Name = "btnNextKol";
            this.btnNextKol.Size = new System.Drawing.Size(68, 140);
            this.btnNextKol.TabIndex = 1;
            this.btnNextKol.Text = ">";
            this.btnNextKol.UseVisualStyleBackColor = true;
            this.btnNextKol.Click += new System.EventHandler(this.btnNextKol_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(326, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 17);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search collections:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(495, 25);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(200, 22);
            this.tbxSearch.TabIndex = 6;
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(47, 371);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.RowHeadersWidth = 51;
            this.dgvPrikaz.RowTemplate.Height = 24;
            this.dgvPrikaz.Size = new System.Drawing.Size(752, 451);
            this.dgvPrikaz.TabIndex = 7;
            this.dgvPrikaz.Visible = false;
            // 
            // gbLista
            // 
            this.gbLista.Location = new System.Drawing.Point(13, 57);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(927, 470);
            this.gbLista.TabIndex = 8;
            this.gbLista.TabStop = false;
            this.gbLista.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(729, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // KorisnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 597);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.gbLista);
            this.Name = "KorisnikForma";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.KorisnikForma_Load);
            this.gbPrikaz.ResumeLayout(false);
            this.gbPrikaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.Button btnPrevKol;
        private System.Windows.Forms.Button btnNextKol;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private UserControl2 userControl2;
        private UserControl1 userControl1;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.GroupBox gbLista;
        private Layouts.Layout4Products layout4Products;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblImeKol;
    }
}