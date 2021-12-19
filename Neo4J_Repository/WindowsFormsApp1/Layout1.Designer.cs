namespace WindowsFormsApp1
{
    partial class Layout1
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
            this.pbxPicture1 = new System.Windows.Forms.PictureBox();
            this.pbxPicture2 = new System.Windows.Forms.PictureBox();
            this.pbxPicture3 = new System.Windows.Forms.PictureBox();
            this.btnDetails1 = new System.Windows.Forms.Button();
            this.btnDetails2 = new System.Windows.Forms.Button();
            this.btnDetails3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPicture1
            // 
            this.pbxPicture1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxPicture1.Location = new System.Drawing.Point(30, 9);
            this.pbxPicture1.Name = "pbxPicture1";
            this.pbxPicture1.Size = new System.Drawing.Size(178, 113);
            this.pbxPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture1.TabIndex = 0;
            this.pbxPicture1.TabStop = false;
            // 
            // pbxPicture2
            // 
            this.pbxPicture2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbxPicture2.Location = new System.Drawing.Point(30, 128);
            this.pbxPicture2.Name = "pbxPicture2";
            this.pbxPicture2.Size = new System.Drawing.Size(178, 113);
            this.pbxPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture2.TabIndex = 1;
            this.pbxPicture2.TabStop = false;
            // 
            // pbxPicture3
            // 
            this.pbxPicture3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxPicture3.Location = new System.Drawing.Point(30, 247);
            this.pbxPicture3.Name = "pbxPicture3";
            this.pbxPicture3.Size = new System.Drawing.Size(178, 113);
            this.pbxPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPicture3.TabIndex = 2;
            this.pbxPicture3.TabStop = false;
            // 
            // btnDetails1
            // 
            this.btnDetails1.Location = new System.Drawing.Point(275, 29);
            this.btnDetails1.Name = "btnDetails1";
            this.btnDetails1.Size = new System.Drawing.Size(85, 76);
            this.btnDetails1.TabIndex = 3;
            this.btnDetails1.Text = "Details";
            this.btnDetails1.UseVisualStyleBackColor = true;
            this.btnDetails1.Click += new System.EventHandler(this.btnDetails1_Click);
            // 
            // btnDetails2
            // 
            this.btnDetails2.Location = new System.Drawing.Point(275, 146);
            this.btnDetails2.Name = "btnDetails2";
            this.btnDetails2.Size = new System.Drawing.Size(85, 76);
            this.btnDetails2.TabIndex = 4;
            this.btnDetails2.Text = "Details";
            this.btnDetails2.UseVisualStyleBackColor = true;
            this.btnDetails2.Click += new System.EventHandler(this.btnDetails2_Click);
            // 
            // btnDetails3
            // 
            this.btnDetails3.Location = new System.Drawing.Point(275, 267);
            this.btnDetails3.Name = "btnDetails3";
            this.btnDetails3.Size = new System.Drawing.Size(85, 76);
            this.btnDetails3.TabIndex = 5;
            this.btnDetails3.Text = "Details";
            this.btnDetails3.UseVisualStyleBackColor = true;
            this.btnDetails3.Click += new System.EventHandler(this.btnDetails3_Click);
            // 
            // Layout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails3);
            this.Controls.Add(this.btnDetails2);
            this.Controls.Add(this.btnDetails1);
            this.Controls.Add(this.pbxPicture3);
            this.Controls.Add(this.pbxPicture2);
            this.Controls.Add(this.pbxPicture1);
            this.Name = "Layout1";
            this.Size = new System.Drawing.Size(432, 412);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicture1;
        private System.Windows.Forms.PictureBox pbxPicture2;
        private System.Windows.Forms.PictureBox pbxPicture3;
        private System.Windows.Forms.Button btnDetails1;
        private System.Windows.Forms.Button btnDetails2;
        private System.Windows.Forms.Button btnDetails3;
    }
}
