using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdm
{
    public partial class fm_menu : Form
    {
        public fm_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cad_prod_Click(object sender, EventArgs e)
        {
            fm_produtos fm = new fm_produtos();
            fm.Show();

        }

        private void btn_categ_Click(object sender, EventArgs e)
        {
            fm_categorias fm = new fm_categorias();
            fm.Show();

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_produtos fm = new fm_produtos();
            fm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_produtos fm = new fm_produtos();
            fm.Show();

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_categorias fm = new fm_categorias();
            fm.Show();

            
        }
    }
}
