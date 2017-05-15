namespace Projeto
{
    partial class formUserAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.ListBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAddNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Admistradores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAdmin
            // 
            this.lbAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAdmin.FormattingEnabled = true;
            this.lbAdmin.ItemHeight = 20;
            this.lbAdmin.Location = new System.Drawing.Point(12, 62);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(510, 144);
            this.lbAdmin.TabIndex = 1;
            this.lbAdmin.SelectedIndexChanged += new System.EventHandler(this.lbAdmin_SelectedIndexChanged);
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Location = new System.Drawing.Point(446, 227);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 2;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAddNovo
            // 
            this.btAddNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNovo.Location = new System.Drawing.Point(322, 227);
            this.btAddNovo.Name = "btAddNovo";
            this.btAddNovo.Size = new System.Drawing.Size(103, 23);
            this.btAddNovo.TabIndex = 2;
            this.btAddNovo.Text = "Adicionar Novo";
            this.btAddNovo.UseVisualStyleBackColor = true;
            this.btAddNovo.Click += new System.EventHandler(this.btAddNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(231, 227);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // formUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 262);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAddNovo);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "formUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Administradores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formUserAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdmin;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAddNovo;
        private System.Windows.Forms.Button btEditar;
    }
}