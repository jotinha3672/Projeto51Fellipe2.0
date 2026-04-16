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
        public ReceitaCard()
        {
            InitializeComponent();
            ArredondarCantos(30);
        }

        public void SetDados(string nome, string descricao, string tempo, byte[] imagemBytes)
        {
            lblNome.Text = nome;

            lblDescricao.Text = descricao.Length > 80
                ? descricao.Substring(0, 80) + "..."
                : descricao;

            lblTempo.Text = "⏱ " + tempo + " min";

            // Converter imagem do banco
            if (imagemBytes != null && imagemBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
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
        private void ReceitaCard_Load(object sender, EventArgs e)
        {

        }
    }
}
