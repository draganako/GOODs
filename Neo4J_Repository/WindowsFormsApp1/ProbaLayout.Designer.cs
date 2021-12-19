namespace WindowsFormsApp1
{
    partial class ProbaLayout
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
            this.tbxProba1 = new System.Windows.Forms.TextBox();
            this.tbxProba3 = new System.Windows.Forms.TextBox();
            this.tbxProba2 = new System.Windows.Forms.TextBox();
            this.btnProba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxProba1
            // 
            this.tbxProba1.Location = new System.Drawing.Point(36, 45);
            this.tbxProba1.Name = "tbxProba1";
            this.tbxProba1.Size = new System.Drawing.Size(362, 22);
            this.tbxProba1.TabIndex = 0;
            this.tbxProba1.TextChanged += new System.EventHandler(this.tbxProba1_TextChanged);
            // 
            // tbxProba3
            // 
            this.tbxProba3.Location = new System.Drawing.Point(36, 163);
            this.tbxProba3.Name = "tbxProba3";
            this.tbxProba3.Size = new System.Drawing.Size(362, 22);
            this.tbxProba3.TabIndex = 1;
            this.tbxProba3.TextChanged += new System.EventHandler(this.tbxProba3_TextChanged);
            // 
            // tbxProba2
            // 
            this.tbxProba2.Location = new System.Drawing.Point(36, 102);
            this.tbxProba2.Name = "tbxProba2";
            this.tbxProba2.Size = new System.Drawing.Size(362, 22);
            this.tbxProba2.TabIndex = 2;
            this.tbxProba2.TextChanged += new System.EventHandler(this.tbxProba2_TextChanged);
            // 
            // btnProba
            // 
            this.btnProba.Location = new System.Drawing.Point(82, 221);
            this.btnProba.Name = "btnProba";
            this.btnProba.Size = new System.Drawing.Size(276, 145);
            this.btnProba.TabIndex = 3;
            this.btnProba.Text = "Fill the blanks";
            this.btnProba.UseVisualStyleBackColor = true;
            this.btnProba.Click += new System.EventHandler(this.btnProba_Click);
            // 
            // ProbaLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProba);
            this.Controls.Add(this.tbxProba2);
            this.Controls.Add(this.tbxProba3);
            this.Controls.Add(this.tbxProba1);
            this.Name = "ProbaLayout";
            this.Size = new System.Drawing.Size(448, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxProba1;
        private System.Windows.Forms.TextBox tbxProba3;
        private System.Windows.Forms.TextBox tbxProba2;
        private System.Windows.Forms.Button btnProba;
    }
}
