using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Projeto51Fellipe2._0
{
    public partial class FormDetalheReceita : Form
    {
        public FormDetalheReceita()
        {
            InitializeComponent();
        }
        private int idReceita;

        public FormDetalheReceita(int id)
        {
            InitializeComponent();
            idReceita = id;
        }

        public void SetDados(
             string nome,
             string categoria,
             string descricao,
             string tempo,
             byte[] imagem,
             int calorias,
             List<IngredienteReceita> ingredientes){
            lblNome.Text = nome;
            lblCategoria.Text = categoria;
            lblTempo.Text = tempo;
            txtDescricao.Text = descricao;
            lblCalorias.Text = Convert.ToString(calorias);

            // 🖼️ imagem
            if (imagem != null)
            {
                using (var ms = new MemoryStream(imagem))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }

            // 🧂 ingredientes
            flowIngredientes.Controls.Clear();

            foreach (var ing in ingredientes)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                string unidadeFormatada = ing.Unidade;

                // plural simples
                if (ing.Quantidade != "1")
                {
                    if (unidadeFormatada == "colher") unidadeFormatada = "colheres";
                    else if (unidadeFormatada == "xícara") unidadeFormatada = "xícaras";
                    else if (unidadeFormatada == "unidade") unidadeFormatada = "unidades";
                }

                lbl.Text = $"• {ing.Quantidade} {unidadeFormatada} de {ing.Nome}";

                flowIngredientes.Controls.Add(lbl);
            }
        }

        private void FormDetalheReceita_Load(object sender, EventArgs e)
        {

                Repositorio repo = new Repositorio();

                var receita = repo.BuscarReceitaPorId(idReceita);
                var ingredientes = repo.BuscarIngredientes(idReceita);

                lblNome.Text = receita.Nome;
                lblCategoria.Text = receita.Categoria;
                lblTempo.Text = "⏱ " + receita.Tempo + " min";
                lblCalorias.Text = Convert.ToString(receita.Calorias) + " Calorias";
                txtDescricao.Text = receita.Descricao;
            
            if (receita.Imagem != null)
                {
                    using (var ms = new MemoryStream(receita.Imagem))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }

            StringBuilder sb = new StringBuilder();

            string textoModo = receita.ModoPreparo ?? "";

            var passos = textoModo
                .Split(new[] { '.', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int contador = 1;

            foreach (var passo in passos)
            {
                if (!string.IsNullOrWhiteSpace(passo))
                {
                    sb.AppendLine($"{contador}. {passo.Trim()}");
                    contador++;
                }
            }

            lblModoPrep.Text = "Modo de Preparo:\n\n" + sb.ToString();

            // ingredientes (igual você já faz)

            flowIngredientes.Controls.Clear();

            foreach (var ing in ingredientes)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;

                string unidadeFormatada = ing.Unidade;

                // plural simples
                if (ing.Quantidade != "1")
                {
                    if (unidadeFormatada == "colher") unidadeFormatada = "colheres";
                    else if (unidadeFormatada == "xícara") unidadeFormatada = "xícaras";
                    else if (unidadeFormatada == "unidade") unidadeFormatada = "unidades";
                }

                lbl.Text = $"• {ing.Quantidade} {unidadeFormatada} de {ing.Nome}";

                flowIngredientes.Controls.Add(lbl);
            }











            //Perfumaria
            this.BackColor = ColorTranslator.FromHtml("#F5F7F2");
            lblNome.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            lblCategoria.Font = new Font("Segoe UI", 15);
            txtDescricao.Font = new Font("Segoe UI", 15);
            lblModoPrep.Font = new Font("Segoe UI", 15);
            lblTempo.Font = new Font("Segoe UI", 15);
            lblCalorias.Font = new Font("Segoe UI", 15);
            exibIngredientes.Font = new Font("Segoe UI", 15);
            flowIngredientes.FlowDirection = FlowDirection.TopDown;
            flowIngredientes.WrapContents = false;
            flowIngredientes.AutoScroll = true;
            flowIngredientes.Padding = new Padding(10);
            flowIngredientes.Font = new Font("Segoe UI", 15);
            
        }
    }
}

