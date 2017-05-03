namespace Projeto
{
    partial class formPickUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPickUser));
            this.btArbrito = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btArbrito
            // 
            this.btArbrito.Image = ((System.Drawing.Image)(resources.GetObject("btArbrito.Image")));
            this.btArbrito.Location = new System.Drawing.Point(29, 32);
            this.btArbrito.Name = "btArbrito";
            this.btArbrito.Size = new System.Drawing.Size(140, 120);
            this.btArbrito.TabIndex = 0;
            this.btArbrito.Text = "Árbitro";
            this.btArbrito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btArbrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btArbrito.UseVisualStyleBackColor = true;
            this.btArbrito.Click += new System.EventHandler(this.clickGestaoArbritos);
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(202, 32);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(140, 120);
            this.btAdmin.TabIndex = 0;
            this.btAdmin.Text = "Administrador";
            this.btAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btArbrito);
            this.groupBox1.Controls.Add(this.btAdmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // formPickUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 213);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPickUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolher Grupo";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btArbrito;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}