namespace Projeto {
    partial class formJogadores {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJogadores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbJogadores = new System.Windows.Forms.ListBox();
            this.gbFormJogador = new System.Windows.Forms.GroupBox();
            this.btLimpaImage = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.tbNickName = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdAvatar = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pBotoes = new System.Windows.Forms.Panel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSearchClear = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbFormJogador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbJogadores);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores:";
            // 
            // lbJogadores
            // 
            this.lbJogadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbJogadores.FormattingEnabled = true;
            this.lbJogadores.ItemHeight = 20;
            this.lbJogadores.Items.AddRange(new object[] {
            "Teste"});
            this.lbJogadores.Location = new System.Drawing.Point(3, 16);
            this.lbJogadores.Name = "lbJogadores";
            this.lbJogadores.Size = new System.Drawing.Size(183, 312);
            this.lbJogadores.TabIndex = 0;
            this.lbJogadores.SelectedIndexChanged += new System.EventHandler(this.lbJogadores_SelectedIndexChanged);
            // 
            // gbFormJogador
            // 
            this.gbFormJogador.Controls.Add(this.btLimpaImage);
            this.gbFormJogador.Controls.Add(this.pbAvatar);
            this.gbFormJogador.Controls.Add(this.nudIdade);
            this.gbFormJogador.Controls.Add(this.tbNickName);
            this.gbFormJogador.Controls.Add(this.tbNome);
            this.gbFormJogador.Controls.Add(this.tbEmail);
            this.gbFormJogador.Controls.Add(this.label4);
            this.gbFormJogador.Controls.Add(this.label3);
            this.gbFormJogador.Controls.Add(this.label2);
            this.gbFormJogador.Controls.Add(this.label1);
            this.gbFormJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFormJogador.Enabled = false;
            this.gbFormJogador.Location = new System.Drawing.Point(0, 0);
            this.gbFormJogador.Name = "gbFormJogador";
            this.gbFormJogador.Size = new System.Drawing.Size(424, 331);
            this.gbFormJogador.TabIndex = 1;
            this.gbFormJogador.TabStop = false;
            this.gbFormJogador.Text = "Dados do Jogador:";
            // 
            // btLimpaImage
            // 
            this.btLimpaImage.Location = new System.Drawing.Point(9, 140);
            this.btLimpaImage.Name = "btLimpaImage";
            this.btLimpaImage.Size = new System.Drawing.Size(110, 23);
            this.btLimpaImage.TabIndex = 12;
            this.btLimpaImage.Text = "Limpar Imagem";
            this.btLimpaImage.UseVisualStyleBackColor = true;
            this.btLimpaImage.Visible = false;
            this.btLimpaImage.Click += new System.EventHandler(this.btLimpaImage_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.ErrorImage = null;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.ImageLocation = "0,0";
            this.pbAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.InitialImage")));
            this.pbAvatar.Location = new System.Drawing.Point(9, 19);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(110, 114);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 11;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // nudIdade
            // 
            this.nudIdade.Location = new System.Drawing.Point(168, 118);
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(54, 20);
            this.nudIdade.TabIndex = 10;
            // 
            // tbNickName
            // 
            this.tbNickName.Location = new System.Drawing.Point(189, 24);
            this.tbNickName.Name = "tbNickName";
            this.tbNickName.Size = new System.Drawing.Size(142, 20);
            this.tbNickName.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Location = new System.Drawing.Point(168, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(249, 20);
            this.tbNome.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(168, 87);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(249, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanel1.Controls.Add(this.pBotoes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 427);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pBotoes
            // 
            this.pBotoes.Controls.Add(this.btGuardar);
            this.pBotoes.Controls.Add(this.btEliminar);
            this.pBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBotoes.Enabled = false;
            this.pBotoes.Location = new System.Drawing.Point(198, 390);
            this.pBotoes.Name = "pBotoes";
            this.pBotoes.Size = new System.Drawing.Size(424, 34);
            this.pBotoes.TabIndex = 2;
            // 
            // btGuardar
            // 
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGuardar.Location = new System.Drawing.Point(0, 0);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(150, 34);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEliminar.Location = new System.Drawing.Point(274, 0);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(150, 34);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFormJogador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 331);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.btSearchClear);
            this.panel3.Controls.Add(this.btSearch);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 44);
            this.panel3.TabIndex = 12;
            // 
            // btSearchClear
            // 
            this.btSearchClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearchClear.Image = ((System.Drawing.Image)(resources.GetObject("btSearchClear.Image")));
            this.btSearchClear.Location = new System.Drawing.Point(572, 6);
            this.btSearchClear.Name = "btSearchClear";
            this.btSearchClear.Size = new System.Drawing.Size(37, 31);
            this.btSearchClear.TabIndex = 5;
            this.btSearchClear.UseVisualStyleBackColor = true;
            this.btSearchClear.Click += new System.EventHandler(this.btSearchClear_Click);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.Transparent;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(529, 6);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(37, 31);
            this.btSearch.TabIndex = 4;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSearch.Location = new System.Drawing.Point(9, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(480, 26);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "Nome do Jogador ...";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btNovo);
            this.panel4.Location = new System.Drawing.Point(3, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 34);
            this.panel4.TabIndex = 13;
            // 
            // btNovo
            // 
            this.btNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNovo.Location = new System.Drawing.Point(0, 0);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(189, 34);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // formJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formJogadores";
            this.Text = "Formulário Jogadores";
            this.groupBox1.ResumeLayout(false);
            this.gbFormJogador.ResumeLayout(false);
            this.gbFormJogador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbJogadores;
        private System.Windows.Forms.GroupBox gbFormJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNickName;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.OpenFileDialog ofdAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBotoes;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.Button btLimpaImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSearchClear;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Panel panel4;
    }
}