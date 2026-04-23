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
using System.Drawing.Drawing2D;

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
            this.BackColor = ColorTranslator.FromHtml("#F5F7F2");
            flowLayoutPanel1.BackColor = this.BackColor;
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
            var ingredientes = Barra.Text.ToLower()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int? categoriaId = ObterCategoriaId();
            List<int> restricoes = ObterRestricoes();
            var (tempoMin, tempoMax) = ObterTempo();

            
            DataTable dt = _r.BuscarAvancado(ingredientes, categoriaId, restricoes, tempoMin, tempoMax);

            CarregarCards(dt);
        }

        private void CarregarCards(DataTable receitas)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in receitas.Rows)
            {
                ReceitaCard card = new ReceitaCard();

                byte[] img = null;

                if (row["Foto"] != DBNull.Value)
                {
                    img = (byte[])row["Foto"];
                }

                int calorias = 0;

                if (row.Table.Columns.Contains("calorias") && row["calorias"] != DBNull.Value)
                {
                    calorias = Convert.ToInt32(row["calorias"]);
                }

                card.IdReceita = Convert.ToInt32(row["id_receita"]);
                card.SetDados
                (
                    row["Nome_Receita"].ToString(),
                    row["tipo"].ToString(),
                    row["Descricao"].ToString(),
                    row["Tempo_Preparo"].ToString(),
                    img,
                    calorias
                );

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private int? ObterCategoriaId()
        {
            if (rbCafe.Checked) return 1;
            if (rbSobremesa.Checked) return 2;
            if (rbRapido.Checked) return 3;
            if (rbCafeTarde.Checked) return 6;
            if (rbAlmoco.Checked) return 7;
            if (rbJantar.Checked) return 8;
            if (rbLancheManha.Checked) return 9;
            if (rbCeia.Checked) return 10;

            return null; // todos
        }
        private (int? tempoMin, int? tempoMax) ObterTempo()
        {
            int? tempoMin = null;
            int? tempoMax = null;

            if (rbAte30.Checked)
            {
                tempoMax = 30;
            }
            else if (rb30a60.Checked)
            {
                tempoMin = 30;
                tempoMax = 60;
            }
            else if (rbMais60.Checked)
            {
                tempoMin = 60;
            }

            return (tempoMin, tempoMax);
        }

        private List<int> ObterRestricoes()
        {
            List<int> restricoes = new List<int>();

            if (cbVegetariano.Checked) restricoes.Add(1);
            if (cbVegano.Checked) restricoes.Add(2);
            if (cbSemLactose.Checked) restricoes.Add(3);
            if (cbSemGluten.Checked) restricoes.Add(4);

            return restricoes;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FormCardapio f = new FormCardapio();
            f.Show();
        }
    }
}

