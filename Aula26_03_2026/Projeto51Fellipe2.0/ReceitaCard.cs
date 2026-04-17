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
    public partial class ReceitaCard : UserControl
    {

        public int IdReceita { get; set; } 

        private byte[] imagemBytes;

        public ReceitaCard()
        {
            InitializeComponent();
            ArredondarCantos(30);
        }

        private void ReceitaCard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.Margin = new Padding(15);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Height = 120;
            this.BorderStyle = BorderStyle.None;
            btnVerMais.BackColor = ColorTranslator.FromHtml("#6BA368");
            btnVerMais.ForeColor = Color.White;
            btnVerMais.FlatStyle = FlatStyle.Flat;
            btnVerMais.FlatAppearance.BorderSize = 0;
            btnVerMais.Height = 20;
            
        }

        public void SetDados(string nome, string categoria, string descricao, string tempo, byte[] foto, int calorias)
        {
            lblNome.Text = nome;
            lblCategoria.Text = categoria;
            lblCalorias.Text = $"{calorias} kcal";
            lblDescricao.Text = descricao.Length > 80
                ? descricao.Substring(0, 80) + "..."
                : descricao;

            lblTempo.Text = "⏱ " + tempo + " min";

            imagemBytes = foto;

            if (foto != null)
            {
                using (MemoryStream ms = new MemoryStream(foto))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.sem_foto;
            }
        }

        private void ArredondarCantos(int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(this.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(this.Width - raio, this.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - raio, raio, raio), 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }
        

        //private void btnVerMais_Click(object sender, EventArgs e)
        //{
        //    Repositorio repo = new Repositorio();

        //    var ingredientes = repo.BuscarIngredientes(IdReceita);

        //    FormDetalheReceita tela = new FormDetalheReceita();

        //    tela.SetDados(
        //        lblNome.Text,
        //        lblCategoria.Text,
        //        lblDescricao.Text,
        //        lblTempo.Text,
        //        imagemBytes,
        //        ingredientes
        //    );

        //    tela.Show();
        //}

        private void btnVerMais_Click_1(object sender, EventArgs e)
        {
            FormDetalheReceita tela = new FormDetalheReceita(IdReceita);
            tela.ShowDialog();
        }

        
    }
}
