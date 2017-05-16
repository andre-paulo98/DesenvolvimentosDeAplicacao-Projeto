namespace Projeto
{
    partial class formUserReferee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserReferee));
            this.label1 = new System.Windows.Forms.Label();
            this.lbArbitros = new System.Windows.Forms.ListBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btPesquisaArbrito = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Árbitros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbArbitros
            // 
            this.lbArbitros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArbitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArbitros.FormattingEnabled = true;
            this.lbArbitros.ItemHeight = 20;
            this.lbArbitros.Location = new System.Drawing.Point(12, 98);
            this.lbArbitros.Name = "lbArbitros";
            this.lbArbitros.Size = new System.Drawing.Size(395, 104);
            this.lbArbitros.TabIndex = 1;
            this.lbArbitros.SelectedIndexChanged += new System.EventHandler(this.lbArbitros_SelectedIndexChanged);
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Location = new System.Drawing.Point(332, 227);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 2;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNew.Location = new System.Drawing.Point(218, 227);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(97, 23);
            this.btAddNew.TabIndex = 2;
            this.btAddNew.Text = "Adicionar Novo";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.clickAddArbrito);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(218, 62);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(146, 26);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btPesquisaArbrito
            // 
            this.btPesquisaArbrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisaArbrito.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisaArbrito.Image")));
            this.btPesquisaArbrito.Location = new System.Drawing.Point(370, 57);
            this.btPesquisaArbrito.Name = "btPesquisaArbrito";
            this.btPesquisaArbrito.Size = new System.Drawing.Size(37, 31);
            this.btPesquisaArbrito.TabIndex = 4;
            this.btPesquisaArbrito.UseVisualStyleBackColor = true;
            this.btPesquisaArbrito.Click += new System.EventHandler(this.btPesquisaArbrito_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(128, 227);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // formUserReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 262);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btPesquisaArbrito);
            this.Controls.Add(this.lbArbitros);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(348, 290);
            this.Name = "formUserReferee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Árbitros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbArbitros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btPesquisaArbrito;
        private System.Windows.Forms.Button btEditar;
    }
}