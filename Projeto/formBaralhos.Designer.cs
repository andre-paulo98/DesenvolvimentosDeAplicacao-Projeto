namespace Projeto {
    partial class formBaralhos {
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
            this.lbBaralhos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCartas = new System.Windows.Forms.ListBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBaralhos
            // 
            this.lbBaralhos.FormattingEnabled = true;
            this.lbBaralhos.Items.AddRange(new object[] {
            "Baralho1",
            "Baralho2",
            "Baralho3"});
            this.lbBaralhos.Location = new System.Drawing.Point(12, 33);
            this.lbBaralhos.Name = "lbBaralhos";
            this.lbBaralhos.Size = new System.Drawing.Size(162, 290);
            this.lbBaralhos.TabIndex = 0;
            this.lbBaralhos.SelectedIndexChanged += new System.EventHandler(this.lbBaralhos_SelectedIndexChanged);
            this.lbBaralhos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBaralhos_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Baralhos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Cartas:";
            // 
            // lbCartas
            // 
            this.lbCartas.FormattingEnabled = true;
            this.lbCartas.Location = new System.Drawing.Point(206, 33);
            this.lbCartas.Name = "lbCartas";
            this.lbCartas.Size = new System.Drawing.Size(162, 316);
            this.lbCartas.TabIndex = 3;
            this.lbCartas.Visible = false;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(12, 329);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(78, 23);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(96, 329);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(78, 23);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Remover";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(214, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione um baralho para ver as cartas associadas.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formBaralhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.lbCartas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBaralhos);
            this.Name = "formBaralhos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Baralhos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBaralhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbCartas;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label3;
    }
}