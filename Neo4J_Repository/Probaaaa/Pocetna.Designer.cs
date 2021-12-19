namespace Probaaaa
{
    partial class Pocetna
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGenTestData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 201);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 57);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(157, 101);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(219, 22);
            this.tbxUsername.TabIndex = 1;
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(157, 152);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(219, 22);
            this.tbxPass.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(276, 201);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 57);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGenTestData
            // 
            this.btnGenTestData.Location = new System.Drawing.Point(12, 374);
            this.btnGenTestData.Name = "btnGenTestData";
            this.btnGenTestData.Size = new System.Drawing.Size(129, 49);
            this.btnGenTestData.TabIndex = 16;
            this.btnGenTestData.Text = "Generate test data";
            this.btnGenTestData.UseVisualStyleBackColor = true;
            this.btnGenTestData.Click += new System.EventHandler(this.btnGenTestData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "GOODs";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenTestData);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "Pocetna";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnGenTestData;
        private System.Windows.Forms.Label label1;
    }
}