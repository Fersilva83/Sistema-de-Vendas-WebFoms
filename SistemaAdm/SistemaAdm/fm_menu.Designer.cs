
namespace SistemaAdm
{
    partial class fm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_categ = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_cad_prod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_categ
            // 
            this.btn_categ.BackColor = System.Drawing.SystemColors.Info;
            this.btn_categ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_categ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_categ.Font = new System.Drawing.Font("Cooper Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_categ.Image = global::SistemaAdm.Properties.Resources.categoria6;
            this.btn_categ.Location = new System.Drawing.Point(21, 246);
            this.btn_categ.Name = "btn_categ";
            this.btn_categ.Size = new System.Drawing.Size(130, 73);
            this.btn_categ.TabIndex = 4;
            this.btn_categ.Text = "Categorias";
            this.btn_categ.UseVisualStyleBackColor = false;
            this.btn_categ.Click += new System.EventHandler(this.btn_categ_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.BackColor = System.Drawing.SystemColors.Info;
            this.btn_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prod.Font = new System.Drawing.Font("Cooper Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_prod.Image = global::SistemaAdm.Properties.Resources.produto5;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_prod.Location = new System.Drawing.Point(21, 138);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(130, 87);
            this.btn_prod.TabIndex = 3;
            this.btn_prod.Text = "Produtos";
            this.btn_prod.UseVisualStyleBackColor = false;
            // 
            // btn_cad_prod
            // 
            this.btn_cad_prod.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cad_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_prod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_prod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_prod.Font = new System.Drawing.Font("Cooper Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_prod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_cad_prod.Image = global::SistemaAdm.Properties.Resources.cadastro2;
            this.btn_cad_prod.Location = new System.Drawing.Point(21, 38);
            this.btn_cad_prod.Name = "btn_cad_prod";
            this.btn_cad_prod.Size = new System.Drawing.Size(130, 74);
            this.btn_cad_prod.TabIndex = 2;
            this.btn_cad_prod.Text = "Cadastrar Produtos";
            this.btn_cad_prod.UseVisualStyleBackColor = false;
            this.btn_cad_prod.Click += new System.EventHandler(this.btn_cad_prod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SistemaAdm.Properties.Resources.loj;
            this.pictureBox1.Location = new System.Drawing.Point(192, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(661, 387);
            this.Controls.Add(this.btn_categ);
            this.Controls.Add(this.btn_prod);
            this.Controls.Add(this.btn_cad_prod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_prod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_categ;
    }
}

