
namespace SistemaAdm
{
    partial class fm_produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cb_categ = new System.Windows.Forms.ComboBox();
            this.bnt_novo = new System.Windows.Forms.Button();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.bnt_excluir = new System.Windows.Forms.Button();
            this.bnt_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIÇÃO";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(113, 10);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(187, 20);
            this.txt_descricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "VALOR";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(390, 8);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(187, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // cb_categ
            // 
            this.cb_categ.FormattingEnabled = true;
            this.cb_categ.Location = new System.Drawing.Point(697, 9);
            this.cb_categ.Name = "cb_categ";
            this.cb_categ.Size = new System.Drawing.Size(187, 21);
            this.cb_categ.TabIndex = 6;
            // 
            // bnt_novo
            // 
            this.bnt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_novo.Location = new System.Drawing.Point(155, 59);
            this.bnt_novo.Name = "bnt_novo";
            this.bnt_novo.Size = new System.Drawing.Size(86, 23);
            this.bnt_novo.TabIndex = 7;
            this.bnt_novo.Text = "NOVO";
            this.bnt_novo.UseVisualStyleBackColor = true;
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_cadastrar.Location = new System.Drawing.Point(290, 59);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(105, 23);
            this.bnt_cadastrar.TabIndex = 8;
            this.bnt_cadastrar.Text = "CADASTRAR";
            this.bnt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bnt_excluir
            // 
            this.bnt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_excluir.Location = new System.Drawing.Point(442, 59);
            this.bnt_excluir.Name = "bnt_excluir";
            this.bnt_excluir.Size = new System.Drawing.Size(94, 23);
            this.bnt_excluir.TabIndex = 9;
            this.bnt_excluir.Text = "EXCLUIR";
            this.bnt_excluir.UseVisualStyleBackColor = true;
            // 
            // bnt_cancelar
            // 
            this.bnt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_cancelar.Location = new System.Drawing.Point(576, 59);
            this.bnt_cancelar.Name = "bnt_cancelar";
            this.bnt_cancelar.Size = new System.Drawing.Size(115, 23);
            this.bnt_cancelar.TabIndex = 10;
            this.bnt_cancelar.Text = "CANCELAR";
            this.bnt_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // fm_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 319);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnt_cancelar);
            this.Controls.Add(this.bnt_excluir);
            this.Controls.Add(this.bnt_cadastrar);
            this.Controls.Add(this.bnt_novo);
            this.Controls.Add(this.cb_categ);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Name = "fm_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros de Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cb_categ;
        private System.Windows.Forms.Button bnt_novo;
        private System.Windows.Forms.Button bnt_cadastrar;
        private System.Windows.Forms.Button bnt_excluir;
        private System.Windows.Forms.Button bnt_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}