namespace Projeto
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUtilizadores = new System.Windows.Forms.Button();
            this.btJogadores = new System.Windows.Forms.Button();
            this.btEquipas = new System.Windows.Forms.Button();
            this.btCartas = new System.Windows.Forms.Button();
            this.btTorneios = new System.Windows.Forms.Button();
            this.btBaralhos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btUtilizadores);
            this.groupBox1.Controls.Add(this.btJogadores);
            this.groupBox1.Controls.Add(this.btEquipas);
            this.groupBox1.Controls.Add(this.btCartas);
            this.groupBox1.Controls.Add(this.btTorneios);
            this.groupBox1.Controls.Add(this.btBaralhos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.Image = ((System.Drawing.Image)(resources.GetObject("btUtilizadores.Image")));
            this.btUtilizadores.Location = new System.Drawing.Point(13, 19);
            this.btUtilizadores.Margin = new System.Windows.Forms.Padding(10);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.Size = new System.Drawing.Size(140, 120);
            this.btUtilizadores.TabIndex = 1;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btUtilizadores.UseVisualStyleBackColor = true;
            this.btUtilizadores.Click += new System.EventHandler(this.btUtilizadores_Click);
            // 
            // btJogadores
            // 
            this.btJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btJogadores.Image = ((System.Drawing.Image)(resources.GetObject("btJogadores.Image")));
            this.btJogadores.Location = new System.Drawing.Point(333, 159);
            this.btJogadores.Margin = new System.Windows.Forms.Padding(10);
            this.btJogadores.Name = "btJogadores";
            this.btJogadores.Size = new System.Drawing.Size(140, 120);
            this.btJogadores.TabIndex = 0;
            this.btJogadores.Text = "Jogadores";
            this.btJogadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btJogadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btJogadores.UseVisualStyleBackColor = true;
            // 
            // btEquipas
            // 
            this.btEquipas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEquipas.Image = ((System.Drawing.Image)(resources.GetObject("btEquipas.Image")));
            this.btEquipas.Location = new System.Drawing.Point(173, 159);
            this.btEquipas.Margin = new System.Windows.Forms.Padding(10);
            this.btEquipas.Name = "btEquipas";
            this.btEquipas.Size = new System.Drawing.Size(140, 120);
            this.btEquipas.TabIndex = 0;
            this.btEquipas.Text = "Equipas";
            this.btEquipas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEquipas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEquipas.UseVisualStyleBackColor = true;
            // 
            // btCartas
            // 
            this.btCartas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCartas.Image = ((System.Drawing.Image)(resources.GetObject("btCartas.Image")));
            this.btCartas.Location = new System.Drawing.Point(333, 19);
            this.btCartas.Margin = new System.Windows.Forms.Padding(10);
            this.btCartas.Name = "btCartas";
            this.btCartas.Size = new System.Drawing.Size(140, 120);
            this.btCartas.TabIndex = 0;
            this.btCartas.Text = "Cartas";
            this.btCartas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCartas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCartas.UseVisualStyleBackColor = true;
            // 
            // btTorneios
            // 
            this.btTorneios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTorneios.Image = ((System.Drawing.Image)(resources.GetObject("btTorneios.Image")));
            this.btTorneios.Location = new System.Drawing.Point(13, 159);
            this.btTorneios.Margin = new System.Windows.Forms.Padding(10);
            this.btTorneios.Name = "btTorneios";
            this.btTorneios.Size = new System.Drawing.Size(140, 120);
            this.btTorneios.TabIndex = 0;
            this.btTorneios.Text = "Torneios";
            this.btTorneios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTorneios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTorneios.UseVisualStyleBackColor = true;
            // 
            // btBaralhos
            // 
            this.btBaralhos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaralhos.Location = new System.Drawing.Point(173, 19);
            this.btBaralhos.Margin = new System.Windows.Forms.Padding(10);
            this.btBaralhos.Name = "btBaralhos";
            this.btBaralhos.Size = new System.Drawing.Size(140, 120);
            this.btBaralhos.TabIndex = 0;
            this.btBaralhos.Text = "Baralhos";
            this.btBaralhos.UseVisualStyleBackColor = true;
            this.btBaralhos.Click += new System.EventHandler(this.btBaralhos_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btJogadores;
        private System.Windows.Forms.Button btEquipas;
        private System.Windows.Forms.Button btCartas;
        private System.Windows.Forms.Button btTorneios;
        private System.Windows.Forms.Button btBaralhos;
        private System.Windows.Forms.Button btUtilizadores;
    }
}