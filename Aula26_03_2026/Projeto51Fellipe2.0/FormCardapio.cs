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
    public partial class FormCardapio : Form
    {
        private readonly Repositorio _r = new Repositorio();

        public FormCardapio()
        {
            InitializeComponent();
        }

        

        // 🔥 EXIBE O CARDÁPIO ESTRUTURADO
        private void ExibirCardapio(CardapioDia cardapio)
        {
            flowLayoutPanel1.Controls.Clear();

            if (cardapio == null)
            {
                MessageBox.Show("Nenhum cardápio encontrado dentro do limite.");
                return;
            }

            // ☀️ Café
            AdicionarTitulo("☀️ Café da manhã");
            AdicionarCard(cardapio.Cafe);

            // 🍽️ Almoço
            AdicionarTitulo("🍽️ Almoço");
            AdicionarCard(cardapio.Almoco);

            // 🌙 Jantar
            AdicionarTitulo("🌙 Jantar");
            AdicionarCard(cardapio.Jantar);

            // 🔥 Total
            Label total = new Label();
            total.Text = $"🔥 Total: {cardapio.TotalCalorias} kcal";
            total.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            total.AutoSize = true;
            total.Margin = new Padding(10);

            flowLayoutPanel1.Controls.Add(total);
        }

        // 🔹 ADICIONA UM CARD
        private void AdicionarCard(Receita receita)
        {
            if (receita == null) return;

            ReceitaCard card = new ReceitaCard();

            card.IdReceita = receita.Id;

            card.SetDados(
                receita.Nome,
                "",     // categoria opcional
                "",     // descrição
                "",     // tempo
                null,   // imagem
                receita.Calorias
            );

            flowLayoutPanel1.Controls.Add(card);
        }

        // 🔹 TÍTULO DAS SEÇÕES
        private void AdicionarTitulo(string texto)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Margin = new Padding(10, 20, 10, 5);

            flowLayoutPanel1.Controls.Add(lbl);
        }

        private void FormCardapio_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F5F7F2");
            flowLayoutPanel1.BackColor = this.BackColor;
        }

        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            
            int limite;

            if (!int.TryParse(txtCalorias.Text, out limite))
            {
                MessageBox.Show("Digite um valor válido.");
                return;
            }

            var cafes = _r.BuscarPorCategoriaSimples(1);
            var almocos = _r.BuscarPorCategoriaSimples(7);
            var jantares = _r.BuscarPorCategoriaSimples(8);

            if (cafes.Count == 0 || almocos.Count == 0 || jantares.Count == 0)
            {
                MessageBox.Show("Dados insuficientes para gerar cardápio.");
                return;
            }

            var gerador = new GeradorCardapio();

            var resultado = gerador.Gerar(limite, cafes, almocos, jantares);

            ExibirCardapio(resultado);
        }
    }
}
