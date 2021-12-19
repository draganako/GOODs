namespace Probaaaa
{
    partial class AdminOpcije
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
            this.lbKatalozi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKatalozi
            // 
            this.lbKatalozi.FormattingEnabled = true;
            this.lbKatalozi.ItemHeight = 16;
            this.lbKatalozi.Location = new System.Drawing.Point(12, 61);
            this.lbKatalozi.Name = "lbKatalozi";
            this.lbKatalozi.Size = new System.Drawing.Size(740, 340);
            this.lbKatalozi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current catalogs";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(502, 513);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(123, 46);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Done";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add new catalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(641, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdminOpcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 571);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKatalozi);
            this.Name = "AdminOpcije";
            this.Text = "Catalogs";
            this.Load += new System.EventHandler(this.AdminOpcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKatalozi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
    }
}