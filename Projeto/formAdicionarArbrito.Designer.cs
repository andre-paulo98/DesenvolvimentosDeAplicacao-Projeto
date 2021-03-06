﻿namespace Projeto
{
    partial class formAdicionarArbrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdicionarArbrito));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(90, 72);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(269, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_enter);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(88, 146);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(269, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_enter);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(88, 110);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(269, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Avatar";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(468, 226);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(387, 226);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Adicionar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(569, 25);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Adicionar Arbitro";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.BackgroundImage")));
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAvatar.ErrorImage = null;
            this.pbAvatar.InitialImage = null;
            this.pbAvatar.Location = new System.Drawing.Point(445, 12);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(98, 98);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 7;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;\"";
            this.openFileDialog.Title = "Avatar do Arbitro";
            // 
            // btErase
            // 
            this.btErase.Image = ((System.Drawing.Image)(resources.GetObject("btErase.Image")));
            this.btErase.Location = new System.Drawing.Point(483, 133);
            this.btErase.Name = "btErase";
            this.btErase.Size = new System.Drawing.Size(25, 25);
            this.btErase.TabIndex = 8;
            this.btErase.UseVisualStyleBackColor = true;
            this.btErase.Click += new System.EventHandler(this.btErase_Click);
            // 
            // formAdicionarArbrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 261);
            this.Controls.Add(this.btErase);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAdicionarArbrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Árbitro";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btErase;
    }
}