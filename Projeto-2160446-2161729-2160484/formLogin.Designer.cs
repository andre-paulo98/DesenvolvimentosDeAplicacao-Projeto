namespace Projeto_2160446_2161729_2160484 {
    partial class formLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_login);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(68, 34);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(237, 20);
            this.tb_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(68, 60);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(237, 20);
            this.tb_password.TabIndex = 3;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(208, 86);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(97, 22);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 146);
            this.Controls.Add(this.groupBox1);
            this.Name = "formLogin";
            this.Text = "ATM - Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_login;
    }
}

