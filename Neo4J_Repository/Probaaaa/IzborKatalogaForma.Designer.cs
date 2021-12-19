namespace Probaaaa
{
    partial class IzborKatalogaForma
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
            this.btnNewCollection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbxSeason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.dgKolekcije = new System.Windows.Forms.DataGridView();
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKolekcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCollection
            // 
            this.btnNewCollection.Location = new System.Drawing.Point(184, 381);
            this.btnNewCollection.Name = "btnNewCollection";
            this.btnNewCollection.Size = new System.Drawing.Size(129, 38);
            this.btnNewCollection.TabIndex = 0;
            this.btnNewCollection.Text = "Add Collection";
            this.btnNewCollection.UseVisualStyleBackColor = true;
            this.btnNewCollection.Click += new System.EventHandler(this.btnNewCollection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(751, 384);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(115, 38);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tbxSeason
            // 
            this.tbxSeason.Location = new System.Drawing.Point(184, 61);
            this.tbxSeason.Name = "tbxSeason";
            this.tbxSeason.Size = new System.Drawing.Size(143, 22);
            this.tbxSeason.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hashtag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year:";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(456, 61);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(143, 22);
            this.tbxYear.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month:";
            // 
            // tbxMonth
            // 
            this.tbxMonth.Location = new System.Drawing.Point(723, 61);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(143, 22);
            this.tbxMonth.TabIndex = 9;
            // 
            // dgKolekcije
            // 
            this.dgKolekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKolekcije.Location = new System.Drawing.Point(12, 144);
            this.dgKolekcije.Name = "dgKolekcije";
            this.dgKolekcije.RowHeadersWidth = 51;
            this.dgKolekcije.RowTemplate.Height = 24;
            this.dgKolekcije.Size = new System.Drawing.Size(494, 228);
            this.dgKolekcije.TabIndex = 11;
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Location = new System.Drawing.Point(554, 144);
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.RowHeadersWidth = 51;
            this.dgProizvodi.RowTemplate.Height = 24;
            this.dgProizvodi.Size = new System.Drawing.Size(494, 228);
            this.dgProizvodi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Collections:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Products:";
            // 
            // IzborKatalogaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgProizvodi);
            this.Controls.Add(this.dgKolekcije);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSeason);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewCollection);
            this.Name = "IzborKatalogaForma";
            this.Text = "Catalog content";
            this.Load += new System.EventHandler(this.IzborKatalogaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKolekcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCollection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox tbxSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.DataGridView dgKolekcije;
        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}