namespace WindowsFormsApp1
{
    partial class ProbaLayoutSmall
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
            this.btnProba = new System.Windows.Forms.Button();
            this.tbxProba2 = new System.Windows.Forms.TextBox();
            this.tbxProba3 = new System.Windows.Forms.TextBox();
            this.tbxProba1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProba
            // 
            this.btnProba.Location = new System.Drawing.Point(70, 190);
            this.btnProba.Name = "btnProba";
            this.btnProba.Size = new System.Drawing.Size(104, 34);
            this.btnProba.TabIndex = 7;
            this.btnProba.Text = "Fill the blanks";
            this.btnProba.UseVisualStyleBackColor = true;
            this.btnProba.Click += new System.EventHandler(this.btnProba_Click);
            // 
            // tbxProba2
            // 
            this.tbxProba2.Location = new System.Drawing.Point(24, 71);
            this.tbxProba2.Name = "tbxProba2";
            this.tbxProba2.Size = new System.Drawing.Size(190, 22);
            this.tbxProba2.TabIndex = 6;
            // 
            // tbxProba3
            // 
            this.tbxProba3.Location = new System.Drawing.Point(24, 132);
            this.tbxProba3.Name = "tbxProba3";
            this.tbxProba3.Size = new System.Drawing.Size(190, 22);
            this.tbxProba3.TabIndex = 5;
            // 
            // tbxProba1
            // 
            this.tbxProba1.Location = new System.Drawing.Point(24, 14);
            this.tbxProba1.Name = "tbxProba1";
            this.tbxProba1.Size = new System.Drawing.Size(190, 22);
            this.tbxProba1.TabIndex = 4;
            // 
            // ProbaLayoutSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProba);
            this.Controls.Add(this.tbxProba2);
            this.Controls.Add(this.tbxProba3);
            this.Controls.Add(this.tbxProba1);
            this.Name = "ProbaLayoutSmall";
            this.Size = new System.Drawing.Size(248, 251);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProba;
        private System.Windows.Forms.TextBox tbxProba2;
        private System.Windows.Forms.TextBox tbxProba3;
        private System.Windows.Forms.TextBox tbxProba1;
    }
}
