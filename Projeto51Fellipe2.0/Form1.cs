using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

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

            DataTable dt = _r.BuscarPorIngredientes(ingredientes);
            CarregarCards(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void CarregarCards(DataTable receitas)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in receitas.Rows)
            {
                ReceitaCard card = new ReceitaCard();

                byte[] img = null;

                if (row["foto"] != DBNull.Value)
                {
                    img = (byte[])row["Foto"];
                }

                card.SetDados(
                    row["Nome_Receita"].ToString(),
                    row["Descricao"].ToString(),
                    row["Tempo_Preparo"].ToString(),
                    img
                );

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        //public void Barra_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

