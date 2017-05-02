namespace Projeto {
    partial class formCartas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCartas));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnCarta = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLealdade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAtaque = new System.Windows.Forms.NumericUpDown();
            this.nudCusto = new System.Windows.Forms.NumericUpDown();
            this.nudDefesa = new System.Windows.Forms.NumericUpDown();
            this.cbFacao = new System.Windows.Forms.ComboBox();
            this.rtbRegras = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCartas = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btNova = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnCarta.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLealdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefesa)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSearch.Location = new System.Drawing.Point(9, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(279, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Procurar ...";
            this.tbSearch.GotFocus += new System.EventHandler(this.tbSearch_GotFocus);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.LostFocus += new System.EventHandler(this.tbSearch_LostFocus);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 495);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btPesquisa);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 44);
            this.panel1.TabIndex = 0;
            // 
            // btPesquisa
            // 
            this.btPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisa.Image")));
            this.btPesquisa.Location = new System.Drawing.Point(294, 6);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(37, 31);
            this.btPesquisa.TabIndex = 1;
            this.btPesquisa.UseVisualStyleBackColor = false;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnBotoes);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(218, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 439);
            this.panel2.TabIndex = 1;
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btApagar);
            this.pnBotoes.Controls.Add(this.btEditar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoes.Enabled = false;
            this.pnBotoes.Location = new System.Drawing.Point(0, 391);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(294, 48);
            this.pnBotoes.TabIndex = 0;
            // 
            // btApagar
            // 
            this.btApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btApagar.Location = new System.Drawing.Point(191, 5);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(100, 40);
            this.btApagar.TabIndex = 1;
            this.btApagar.Text = "Eliminar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditar.Location = new System.Drawing.Point(3, 5);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 40);
            this.btEditar.TabIndex = 0;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnCarta);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 439);
            this.panel5.TabIndex = 0;
            // 
            // pnCarta
            // 
            this.pnCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCarta.Controls.Add(this.panel9);
            this.pnCarta.Controls.Add(this.panel8);
            this.pnCarta.Enabled = false;
            this.pnCarta.Location = new System.Drawing.Point(27, 56);
            this.pnCarta.Margin = new System.Windows.Forms.Padding(30);
            this.pnCarta.Name = "pnCarta";
            this.pnCarta.Size = new System.Drawing.Size(231, 279);
            this.pnCarta.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.nudLealdade);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.nudAtaque);
            this.panel9.Controls.Add(this.nudCusto);
            this.panel9.Controls.Add(this.nudDefesa);
            this.panel9.Controls.Add(this.cbFacao);
            this.panel9.Controls.Add(this.rtbRegras);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 58);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(231, 221);
            this.panel9.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lealdade:";
            // 
            // nudLealdade
            // 
            this.nudLealdade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudLealdade.Location = new System.Drawing.Point(59, 147);
            this.nudLealdade.Name = "nudLealdade";
            this.nudLealdade.Size = new System.Drawing.Size(45, 20);
            this.nudLealdade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "€";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Defesa:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ataque:";
            // 
            // nudAtaque
            // 
            this.nudAtaque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAtaque.Location = new System.Drawing.Point(4, 196);
            this.nudAtaque.Name = "nudAtaque";
            this.nudAtaque.Size = new System.Drawing.Size(45, 20);
            this.nudAtaque.TabIndex = 4;
            // 
            // nudCusto
            // 
            this.nudCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCusto.DecimalPlaces = 2;
            this.nudCusto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCusto.Location = new System.Drawing.Point(144, 196);
            this.nudCusto.Name = "nudCusto";
            this.nudCusto.Size = new System.Drawing.Size(62, 20);
            this.nudCusto.TabIndex = 3;
            // 
            // nudDefesa
            // 
            this.nudDefesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDefesa.Location = new System.Drawing.Point(53, 196);
            this.nudDefesa.Name = "nudDefesa";
            this.nudDefesa.Size = new System.Drawing.Size(45, 20);
            this.nudDefesa.TabIndex = 2;
            // 
            // cbFacao
            // 
            this.cbFacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacao.FormattingEnabled = true;
            this.cbFacao.Items.AddRange(new object[] {
            "Gaian Love for Life",
            "Uneasy Alliance"});
            this.cbFacao.Location = new System.Drawing.Point(4, 3);
            this.cbFacao.Name = "cbFacao";
            this.cbFacao.Size = new System.Drawing.Size(121, 21);
            this.cbFacao.TabIndex = 1;
            // 
            // rtbRegras
            // 
            this.rtbRegras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRegras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRegras.Location = new System.Drawing.Point(2, 32);
            this.rtbRegras.Name = "rtbRegras";
            this.rtbRegras.Size = new System.Drawing.Size(223, 109);
            this.rtbRegras.TabIndex = 0;
            this.rtbRegras.Text = "";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cbTipo);
            this.panel8.Controls.Add(this.tbNome);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(231, 58);
            this.panel8.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Creature",
            "Event",
            "Equipment",
            "Magic",
            "Enchantment",
            "City"});
            this.cbTipo.Location = new System.Drawing.Point(3, 29);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(147, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.Tag = "";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(3, 3);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(212, 20);
            this.tbNome.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 439);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCartas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartas Disponiveis:";
            // 
            // lbCartas
            // 
            this.lbCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCartas.FormattingEnabled = true;
            this.lbCartas.Location = new System.Drawing.Point(3, 16);
            this.lbCartas.Name = "lbCartas";
            this.lbCartas.Size = new System.Drawing.Size(203, 372);
            this.lbCartas.TabIndex = 0;
            this.lbCartas.SelectedIndexChanged += new System.EventHandler(this.lbCartas_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btNova);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 48);
            this.panel4.TabIndex = 0;
            // 
            // btNova
            // 
            this.btNova.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNova.Location = new System.Drawing.Point(42, 5);
            this.btNova.Name = "btNova";
            this.btNova.Size = new System.Drawing.Size(100, 40);
            this.btNova.TabIndex = 0;
            this.btNova.Text = "Nova";
            this.btNova.UseVisualStyleBackColor = true;
            this.btNova.Click += new System.EventHandler(this.btNova_Click);
            // 
            // formCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "formCartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Cartas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnBotoes.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnCarta.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLealdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefesa)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnCarta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btNova;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAtaque;
        private System.Windows.Forms.NumericUpDown nudCusto;
        private System.Windows.Forms.NumericUpDown nudDefesa;
        private System.Windows.Forms.ComboBox cbFacao;
        private System.Windows.Forms.RichTextBox rtbRegras;
        private System.Windows.Forms.ListBox lbCartas;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLealdade;
    }
}