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
            this.groupBox1.Controls.Add(this.btUtilizadores);
            this.groupBox1.Controls.Add(this.btJogadores);
            this.groupBox1.Controls.Add(this.btEquipas);
            this.groupBox1.Controls.Add(this.btCartas);
            this.groupBox1.Controls.Add(this.btTorneios);
            this.groupBox1.Controls.Add(this.btBaralhos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.Image = ((System.Drawing.Image)(resources.GetObject("btUtilizadores.Image")));
            this.btUtilizadores.Location = new System.Drawing.Point(61, 19);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.Size = new System.Drawing.Size(160, 122);
            this.btUtilizadores.TabIndex = 1;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btUtilizadores.UseVisualStyleBackColor = true;
            this.btUtilizadores.Click += new System.EventHandler(this.btUtilizadores_Click);
            // 
            // btJogadores
            // 
            this.btJogadores.Location = new System.Drawing.Point(533, 311);
            this.btJogadores.Name = "btJogadores";
            this.btJogadores.Size = new System.Drawing.Size(157, 24);
            this.btJogadores.TabIndex = 0;
            this.btJogadores.Text = "Jogadores";
            this.btJogadores.UseVisualStyleBackColor = true;
            // 
            // btEquipas
            // 
            this.btEquipas.Location = new System.Drawing.Point(305, 311);
            this.btEquipas.Name = "btEquipas";
            this.btEquipas.Size = new System.Drawing.Size(157, 24);
            this.btEquipas.TabIndex = 0;
            this.btEquipas.Text = "Equipas";
            this.btEquipas.UseVisualStyleBackColor = true;
            // 
            // btCartas
            // 
            this.btCartas.Image = ((System.Drawing.Image)(resources.GetObject("btCartas.Image")));
            this.btCartas.Location = new System.Drawing.Point(533, 19);
            this.btCartas.Name = "btCartas";
            this.btCartas.Size = new System.Drawing.Size(157, 122);
            this.btCartas.TabIndex = 0;
            this.btCartas.Text = "Cartas";
            this.btCartas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCartas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCartas.UseVisualStyleBackColor = true;
            // 
            // btTorneios
            // 
            this.btTorneios.Location = new System.Drawing.Point(64, 311);
            this.btTorneios.Name = "btTorneios";
            this.btTorneios.Size = new System.Drawing.Size(157, 24);
            this.btTorneios.TabIndex = 0;
            this.btTorneios.Text = "Torneios";
            this.btTorneios.UseVisualStyleBackColor = true;
            // 
            // btBaralhos
            // 
            this.btBaralhos.Location = new System.Drawing.Point(305, 117);
            this.btBaralhos.Name = "btBaralhos";
            this.btBaralhos.Size = new System.Drawing.Size(157, 24);
            this.btBaralhos.TabIndex = 0;
            this.btBaralhos.Text = "Baralhos";
            this.btBaralhos.UseVisualStyleBackColor = true;
            this.btBaralhos.Click += new System.EventHandler(this.btBaralhos_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPrincipal";
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