namespace Probaaaa
{
    partial class FormKorisnikKatalozi
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
            this.btnPogledajKolekciju = new System.Windows.Forms.Button();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPogledajKolekciju
            // 
            this.btnPogledajKolekciju.Location = new System.Drawing.Point(604, 309);
            this.btnPogledajKolekciju.Name = "btnPogledajKolekciju";
            this.btnPogledajKolekciju.Size = new System.Drawing.Size(127, 59);
            this.btnPogledajKolekciju.TabIndex = 3;
            this.btnPogledajKolekciju.Text = "View";
            this.btnPogledajKolekciju.UseVisualStyleBackColor = true;
            this.btnPogledajKolekciju.Click += new System.EventHandler(this.btnPogledajKolekciju_Click);
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(69, 83);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.RowTemplate.Height = 24;
            this.dgvDisp.Size = new System.Drawing.Size(662, 165);
            this.dgvDisp.TabIndex = 2;
            this.dgvDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisp_CellContentClick);
            // 
            // FormKorisnikKatalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPogledajKolekciju);
            this.Controls.Add(this.dgvDisp);
            this.Name = "FormKorisnikKatalozi";
            this.Text = "Catalogs";
            this.Load += new System.EventHandler(this.FormKorisnikKatalozi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPogledajKolekciju;
        private System.Windows.Forms.DataGridView dgvDisp;
    }
}