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

namespace Projeto51Fellipe2._0
{
    public partial class ReceitaCard : UserControl
    {
        public ReceitaCard()
        {
            InitializeComponent();
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
    }
}
