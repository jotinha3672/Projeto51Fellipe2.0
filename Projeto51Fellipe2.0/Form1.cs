using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto51Fellipe2._0
{
    public partial class Form1 : Form
    {
        private readonly Repositorio _r = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form2 f2;
        private void btnCad_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form2();
            }

            f2.Show();
            f2.BringToFront();
            this.Hide();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

            var ingredientes = Barra.Text
            .ToLower()
            .Split(new char[] { ',', ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            dataGridView1.DataSource = _r.BuscarPorIngredientes(ingredientes);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Barra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
