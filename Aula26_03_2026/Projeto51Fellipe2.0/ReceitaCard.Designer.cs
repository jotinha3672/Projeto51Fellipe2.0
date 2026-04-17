
namespace Projeto51Fellipe2._0
{
    partial class ReceitaCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnVerMais = new System.Windows.Forms.Button();
            this.lblCalorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 144);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "label1";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(3, 180);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(53, 19);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "label2";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(3, 217);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(53, 19);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "label3";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTempo.Location = new System.Drawing.Point(117, 144);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(53, 19);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "label4";
            // 
            // btnVerMais
            // 
            this.btnVerMais.Location = new System.Drawing.Point(68, 252);
            this.btnVerMais.Name = "btnVerMais";
            this.btnVerMais.Size = new System.Drawing.Size(75, 23);
            this.btnVerMais.TabIndex = 5;
            this.btnVerMais.Text = "Ver mais...";
            this.btnVerMais.UseVisualStyleBackColor = true;
            this.btnVerMais.Click += new System.EventHandler(this.btnVerMais_Click_1);
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCalorias.Location = new System.Drawing.Point(117, 217);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(85, 19);
            this.lblCalorias.TabIndex = 6;
            this.lblCalorias.Text = "lblCalorias";
            // 
            // ReceitaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.btnVerMais);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReceitaCard";
            this.Size = new System.Drawing.Size(210, 283);
            this.Load += new System.EventHandler(this.ReceitaCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnVerMais;
        private System.Windows.Forms.Label lblCalorias;
    }
}
