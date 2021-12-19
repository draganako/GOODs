namespace Probaaaa
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password";
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(287, 281);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 22);
            this.tbxPass.TabIndex = 25;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(287, 243);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 22);
            this.tbxUsername.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(287, 172);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 22);
            this.tbxSurname.TabIndex = 21;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(208, 374);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(161, 66);
            this.btnCreateUser.TabIndex = 20;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(287, 134);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
    }
}