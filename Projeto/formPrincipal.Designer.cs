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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 285);
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
            this.btJogadores.Location = new System.Drawing.Point(333, 155);
            this.btJogadores.Margin = new System.Windows.Forms.Padding(10);
            this.btJogadores.Name = "btJogadores";
            this.btJogadores.Size = new System.Drawing.Size(140, 120);
            this.btJogadores.TabIndex = 0;
            this.btJogadores.Text = "Jogadores";
            this.btJogadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btJogadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btJogadores.UseVisualStyleBackColor = true;
            this.btJogadores.Click += new System.EventHandler(this.btJogadores_Click);
            // 
            // btEquipas
            // 
            this.btEquipas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btEquipas.Image = ((System.Drawing.Image)(resources.GetObject("btEquipas.Image")));
            this.btEquipas.Location = new System.Drawing.Point(173, 155);
            this.btEquipas.Margin = new System.Windows.Forms.Padding(10);
            this.btEquipas.Name = "btEquipas";
            this.btEquipas.Size = new System.Drawing.Size(140, 120);
            this.btEquipas.TabIndex = 0;
            this.btEquipas.Text = "Equipas";
            this.btEquipas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEquipas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEquipas.UseVisualStyleBackColor = true;
            this.btEquipas.Click += new System.EventHandler(this.btEquipas_Click);
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
            this.btCartas.Click += new System.EventHandler(this.btCartas_Click);
            // 
            // btTorneios
            // 
            this.btTorneios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTorneios.Image = ((System.Drawing.Image)(resources.GetObject("btTorneios.Image")));
            this.btTorneios.Location = new System.Drawing.Point(13, 155);
            this.btTorneios.Margin = new System.Windows.Forms.Padding(10);
            this.btTorneios.Name = "btTorneios";
            this.btTorneios.Size = new System.Drawing.Size(140, 120);
            this.btTorneios.TabIndex = 0;
            this.btTorneios.Text = "Torneios";
            this.btTorneios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTorneios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTorneios.UseVisualStyleBackColor = true;
            this.btTorneios.Click += new System.EventHandler(this.btTorneios_Click);
            // 
            // btBaralhos
            // 
            this.btBaralhos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaralhos.Image = ((System.Drawing.Image)(resources.GetObject("btBaralhos.Image")));
            this.btBaralhos.Location = new System.Drawing.Point(173, 19);
            this.btBaralhos.Margin = new System.Windows.Forms.Padding(10);
            this.btBaralhos.Name = "btBaralhos";
            this.btBaralhos.Size = new System.Drawing.Size(140, 120);
            this.btBaralhos.TabIndex = 0;
            this.btBaralhos.Text = "Baralhos";
            this.btBaralhos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaralhos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBaralhos.UseVisualStyleBackColor = true;
            this.btBaralhos.Click += new System.EventHandler(this.btBaralhos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btJogadores;
        private System.Windows.Forms.Button btEquipas;
        private System.Windows.Forms.Button btCartas;
        private System.Windows.Forms.Button btTorneios;
        private System.Windows.Forms.Button btBaralhos;
        private System.Windows.Forms.Button btUtilizadores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}