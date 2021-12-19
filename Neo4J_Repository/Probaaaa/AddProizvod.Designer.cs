namespace Probaaaa
{
    partial class AddProizvod
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProizvod = new System.Windows.Forms.Button();
            this.tbxOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxProducer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProizvod
            // 
            this.btnAddProizvod.Location = new System.Drawing.Point(69, 401);
            this.btnAddProizvod.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProizvod.Name = "btnAddProizvod";
            this.btnAddProizvod.Size = new System.Drawing.Size(99, 28);
            this.btnAddProizvod.TabIndex = 18;
            this.btnAddProizvod.Text = "Add";
            this.btnAddProizvod.UseVisualStyleBackColor = true;
            this.btnAddProizvod.Click += new System.EventHandler(this.btnAddProizvod_Click);
            // 
            // tbxOpis
            // 
            this.tbxOpis.Location = new System.Drawing.Point(25, 284);
            this.tbxOpis.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOpis.Multiline = true;
            this.tbxOpis.Name = "tbxOpis";
            this.tbxOpis.Size = new System.Drawing.Size(294, 95);
            this.tbxOpis.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description:";
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(22, 149);
            this.tbxType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(132, 22);
            this.tbxType.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(22, 43);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(132, 22);
            this.tbxName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Producer:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(22, 202);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(132, 22);
            this.tbxPrice.TabIndex = 22;
            // 
            // tbxProducer
            // 
            this.tbxProducer.Location = new System.Drawing.Point(22, 96);
            this.tbxProducer.Margin = new System.Windows.Forms.Padding(4);
            this.tbxProducer.Name = "tbxProducer";
            this.tbxProducer.Size = new System.Drawing.Size(132, 22);
            this.tbxProducer.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price:";
            // 
            // pbxPicture
            // 
            this.pbxPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxPicture.Location = new System.Drawing.Point(186, 42);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(133, 133);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture.TabIndex = 24;
            this.pbxPicture.TabStop = false;
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "*.jpg|*.png filter??";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(186, 190);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 47);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load picture";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AddProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 454);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxProducer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProizvod);
            this.Controls.Add(this.tbxOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "AddProizvod";
            this.Text = "New Product";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProizvod;
        private System.Windows.Forms.TextBox tbxOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxProducer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoad;
    }
}