namespace Probaaaa
{
    partial class KolekcijaForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbIzborProizvoda = new System.Windows.Forms.GroupBox();
            this.layout2Small = new Probaaaa.Layouts.Layout2Small();
            this.layout1Small = new Probaaaa.Layouts.Layout1Small();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.proizvodLayout = new Probaaaa.Layouts.ProizvodLayout();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSrch = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbxProizvodi = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnNextItem = new System.Windows.Forms.Button();
            this.btnPrevItem = new System.Windows.Forms.Button();
            this.gbLejouti = new System.Windows.Forms.GroupBox();
            this.rbxMix = new System.Windows.Forms.RadioButton();
            this.rbxVertical = new System.Windows.Forms.RadioButton();
            this.layout2Small1 = new Probaaaa.Layouts.Layout2Small();
            this.layout1Small1 = new Probaaaa.Layouts.Layout1Small();
            this.gbTeme = new System.Windows.Forms.GroupBox();
            this.pbTema2 = new System.Windows.Forms.PictureBox();
            this.pbTema1 = new System.Windows.Forms.PictureBox();
            this.rbTema2 = new System.Windows.Forms.RadioButton();
            this.rbTema1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.gbIzborProizvoda.SuspendLayout();
            this.gbPrikaz.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbLejouti.SuspendLayout();
            this.gbTeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(688, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 31);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // gbIzborProizvoda
            // 
            this.gbIzborProizvoda.Controls.Add(this.layout2Small);
            this.gbIzborProizvoda.Controls.Add(this.layout1Small);
            this.gbIzborProizvoda.Controls.Add(this.gbPrikaz);
            this.gbIzborProizvoda.Controls.Add(this.groupBox4);
            this.gbIzborProizvoda.Controls.Add(this.btnNextItem);
            this.gbIzborProizvoda.Controls.Add(this.btnPrevItem);
            this.gbIzborProizvoda.Location = new System.Drawing.Point(15, 49);
            this.gbIzborProizvoda.Name = "gbIzborProizvoda";
            this.gbIzborProizvoda.Size = new System.Drawing.Size(986, 516);
            this.gbIzborProizvoda.TabIndex = 8;
            this.gbIzborProizvoda.TabStop = false;
            this.gbIzborProizvoda.Text = "Choose products";
            // 
            // layout2Small
            // 
            this.layout2Small.Location = new System.Drawing.Point(61, 29);
            this.layout2Small.Name = "layout2Small";
            this.layout2Small.Size = new System.Drawing.Size(230, 230);
            this.layout2Small.TabIndex = 12;
            // 
            // layout1Small
            // 
            this.layout1Small.Location = new System.Drawing.Point(61, 29);
            this.layout1Small.Name = "layout1Small";
            this.layout1Small.Size = new System.Drawing.Size(230, 230);
            this.layout1Small.TabIndex = 11;
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.Controls.Add(this.proizvodLayout);
            this.gbPrikaz.Location = new System.Drawing.Point(61, 261);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(266, 221);
            this.gbPrikaz.TabIndex = 10;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Product info";
            // 
            // proizvodLayout
            // 
            this.proizvodLayout.Location = new System.Drawing.Point(36, 21);
            this.proizvodLayout.Name = "proizvodLayout";
            this.proizvodLayout.Size = new System.Drawing.Size(179, 191);
            this.proizvodLayout.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearSearch);
            this.groupBox4.Controls.Add(this.btnSrch);
            this.groupBox4.Controls.Add(this.btnAddProduct);
            this.groupBox4.Controls.Add(this.lbxProizvodi);
            this.groupBox4.Controls.Add(this.tbxSearch);
            this.groupBox4.Location = new System.Drawing.Point(373, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 412);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(285, 31);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(107, 23);
            this.btnClearSearch.TabIndex = 15;
            this.btnClearSearch.Text = "Clear search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSrch
            // 
            this.btnSrch.Location = new System.Drawing.Point(199, 32);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(71, 23);
            this.btnSrch.TabIndex = 14;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(382, 371);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(204, 23);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Add new product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // lbxProizvodi
            // 
            this.lbxProizvodi.FormattingEnabled = true;
            this.lbxProizvodi.ItemHeight = 16;
            this.lbxProizvodi.Location = new System.Drawing.Point(20, 80);
            this.lbxProizvodi.Name = "lbxProizvodi";
            this.lbxProizvodi.Size = new System.Drawing.Size(566, 276);
            this.lbxProizvodi.TabIndex = 4;
            this.lbxProizvodi.SelectedIndexChanged += new System.EventHandler(this.lbxProizvodi_SelectedIndexChanged_1);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(20, 34);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(160, 22);
            this.tbxSearch.TabIndex = 7;
            // 
            // btnNextItem
            // 
            this.btnNextItem.Location = new System.Drawing.Point(838, 50);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(75, 23);
            this.btnNextItem.TabIndex = 6;
            this.btnNextItem.Text = "Next";
            this.btnNextItem.UseVisualStyleBackColor = true;
            this.btnNextItem.Click += new System.EventHandler(this.btnNextItem_Click_1);
            // 
            // btnPrevItem
            // 
            this.btnPrevItem.Location = new System.Drawing.Point(729, 50);
            this.btnPrevItem.Name = "btnPrevItem";
            this.btnPrevItem.Size = new System.Drawing.Size(75, 23);
            this.btnPrevItem.TabIndex = 5;
            this.btnPrevItem.Text = "Previous";
            this.btnPrevItem.UseVisualStyleBackColor = true;
            this.btnPrevItem.Click += new System.EventHandler(this.btnPrevItem_Click);
            // 
            // gbLejouti
            // 
            this.gbLejouti.Controls.Add(this.rbxMix);
            this.gbLejouti.Controls.Add(this.rbxVertical);
            this.gbLejouti.Controls.Add(this.layout2Small1);
            this.gbLejouti.Controls.Add(this.layout1Small1);
            this.gbLejouti.Location = new System.Drawing.Point(9, 49);
            this.gbLejouti.Name = "gbLejouti";
            this.gbLejouti.Size = new System.Drawing.Size(986, 469);
            this.gbLejouti.TabIndex = 5;
            this.gbLejouti.TabStop = false;
            this.gbLejouti.Text = "Layouts";
            // 
            // rbxMix
            // 
            this.rbxMix.AutoSize = true;
            this.rbxMix.Location = new System.Drawing.Point(634, 299);
            this.rbxMix.Name = "rbxMix";
            this.rbxMix.Size = new System.Drawing.Size(65, 21);
            this.rbxMix.TabIndex = 7;
            this.rbxMix.Text = "Mixed";
            this.rbxMix.UseVisualStyleBackColor = true;
            // 
            // rbxVertical
            // 
            this.rbxVertical.AutoSize = true;
            this.rbxVertical.Checked = true;
            this.rbxVertical.Location = new System.Drawing.Point(261, 299);
            this.rbxVertical.Name = "rbxVertical";
            this.rbxVertical.Size = new System.Drawing.Size(76, 21);
            this.rbxVertical.TabIndex = 6;
            this.rbxVertical.TabStop = true;
            this.rbxVertical.Text = "Vertical";
            this.rbxVertical.UseVisualStyleBackColor = true;
            // 
            // layout2Small1
            // 
            this.layout2Small1.Location = new System.Drawing.Point(552, 67);
            this.layout2Small1.Name = "layout2Small1";
            this.layout2Small1.Size = new System.Drawing.Size(230, 230);
            this.layout2Small1.TabIndex = 5;
            // 
            // layout1Small1
            // 
            this.layout1Small1.Location = new System.Drawing.Point(185, 67);
            this.layout1Small1.Name = "layout1Small1";
            this.layout1Small1.Size = new System.Drawing.Size(230, 230);
            this.layout1Small1.TabIndex = 4;
            // 
            // gbTeme
            // 
            this.gbTeme.Controls.Add(this.pbTema2);
            this.gbTeme.Controls.Add(this.pbTema1);
            this.gbTeme.Controls.Add(this.rbTema2);
            this.gbTeme.Controls.Add(this.rbTema1);
            this.gbTeme.Location = new System.Drawing.Point(28, 78);
            this.gbTeme.Name = "gbTeme";
            this.gbTeme.Size = new System.Drawing.Size(973, 459);
            this.gbTeme.TabIndex = 7;
            this.gbTeme.TabStop = false;
            this.gbTeme.Text = "Themes";
            // 
            // pbTema2
            // 
            this.pbTema2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbTema2.Location = new System.Drawing.Point(520, 123);
            this.pbTema2.Name = "pbTema2";
            this.pbTema2.Size = new System.Drawing.Size(153, 197);
            this.pbTema2.TabIndex = 13;
            this.pbTema2.TabStop = false;
            // 
            // pbTema1
            // 
            this.pbTema1.BackColor = System.Drawing.Color.Salmon;
            this.pbTema1.Location = new System.Drawing.Point(144, 112);
            this.pbTema1.Name = "pbTema1";
            this.pbTema1.Size = new System.Drawing.Size(153, 197);
            this.pbTema1.TabIndex = 12;
            this.pbTema1.TabStop = false;
            // 
            // rbTema2
            // 
            this.rbTema2.AutoSize = true;
            this.rbTema2.Location = new System.Drawing.Point(559, 344);
            this.rbTema2.Name = "rbTema2";
            this.rbTema2.Size = new System.Drawing.Size(71, 21);
            this.rbTema2.TabIndex = 11;
            this.rbTema2.Text = "Ocean";
            this.rbTema2.UseVisualStyleBackColor = true;
            // 
            // rbTema1
            // 
            this.rbTema1.AutoSize = true;
            this.rbTema1.Checked = true;
            this.rbTema1.Location = new System.Drawing.Point(186, 344);
            this.rbTema1.Name = "rbTema1";
            this.rbTema1.Size = new System.Drawing.Size(58, 21);
            this.rbTema1.TabIndex = 10;
            this.rbTema1.TabStop = true;
            this.rbTema1.Text = "Girly";
            this.rbTema1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Collection name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(138, 16);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(116, 22);
            this.tbxName.TabIndex = 11;
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.Location = new System.Drawing.Point(503, 12);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(132, 31);
            this.btnAddDesc.TabIndex = 12;
            this.btnAddDesc.Text = "Add description";
            this.btnAddDesc.UseVisualStyleBackColor = true;
            this.btnAddDesc.Click += new System.EventHandler(this.button3_Click);
            // 
            // KolekcijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 577);
            this.Controls.Add(this.btnAddDesc);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbIzborProizvoda);
            this.Controls.Add(this.gbLejouti);
            this.Controls.Add(this.gbTeme);
            this.Name = "KolekcijaForma";
            this.Text = "Kolekcija";
            this.Load += new System.EventHandler(this.KatalogForma_Load);
            this.gbIzborProizvoda.ResumeLayout(false);
            this.gbPrikaz.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbLejouti.ResumeLayout(false);
            this.gbLejouti.PerformLayout();
            this.gbTeme.ResumeLayout(false);
            this.gbTeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTema1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbIzborProizvoda;
        private Layouts.Layout2Small layout2Small;
        private Layouts.Layout1Small layout1Small;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private Layouts.ProizvodLayout proizvodLayout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lbxProizvodi;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnNextItem;
        private System.Windows.Forms.Button btnPrevItem;
        private System.Windows.Forms.GroupBox gbLejouti;
        private System.Windows.Forms.RadioButton rbxMix;
        private System.Windows.Forms.RadioButton rbxVertical;
        private Layouts.Layout2Small layout2Small1;
        private Layouts.Layout1Small layout1Small1;
        private System.Windows.Forms.GroupBox gbTeme;
        private System.Windows.Forms.PictureBox pbTema2;
        private System.Windows.Forms.PictureBox pbTema1;
        private System.Windows.Forms.RadioButton rbTema2;
        private System.Windows.Forms.RadioButton rbTema1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddDesc;
    }
}