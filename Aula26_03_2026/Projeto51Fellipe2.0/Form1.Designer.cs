
namespace Projeto51Fellipe2._0
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbCafe = new System.Windows.Forms.RadioButton();
            this.rbSobremesa = new System.Windows.Forms.RadioButton();
            this.rbRapido = new System.Windows.Forms.RadioButton();
            this.rbAte30 = new System.Windows.Forms.RadioButton();
            this.rb30a60 = new System.Windows.Forms.RadioButton();
            this.rbMais60 = new System.Windows.Forms.RadioButton();
            this.cbVegetariano = new System.Windows.Forms.CheckBox();
            this.cbVegano = new System.Windows.Forms.CheckBox();
            this.cbSemLactose = new System.Windows.Forms.CheckBox();
            this.cbSemGluten = new System.Windows.Forms.CheckBox();
            this.rbAlmoco = new System.Windows.Forms.RadioButton();
            this.rbCafeTarde = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbJantar = new System.Windows.Forms.RadioButton();
            this.rbLancheManha = new System.Windows.Forms.RadioButton();
            this.rbCeia = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnpesquisar.Location = new System.Drawing.Point(937, 23);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(100, 36);
            this.btnpesquisar.TabIndex = 0;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // Barra
            // 
            this.Barra.Location = new System.Drawing.Point(226, 31);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(696, 20);
            this.Barra.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(226, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 538);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(226, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // rbCafe
            // 
            this.rbCafe.AutoSize = true;
            this.rbCafe.Location = new System.Drawing.Point(33, 253);
            this.rbCafe.Name = "rbCafe";
            this.rbCafe.Size = new System.Drawing.Size(97, 17);
            this.rbCafe.TabIndex = 5;
            this.rbCafe.TabStop = true;
            this.rbCafe.Text = "Café da manhã";
            this.rbCafe.UseVisualStyleBackColor = true;
            // 
            // rbSobremesa
            // 
            this.rbSobremesa.AutoSize = true;
            this.rbSobremesa.Location = new System.Drawing.Point(33, 315);
            this.rbSobremesa.Name = "rbSobremesa";
            this.rbSobremesa.Size = new System.Drawing.Size(78, 17);
            this.rbSobremesa.TabIndex = 6;
            this.rbSobremesa.TabStop = true;
            this.rbSobremesa.Text = "Sobremesa";
            this.rbSobremesa.UseVisualStyleBackColor = true;
            // 
            // rbRapido
            // 
            this.rbRapido.AutoSize = true;
            this.rbRapido.Location = new System.Drawing.Point(33, 377);
            this.rbRapido.Name = "rbRapido";
            this.rbRapido.Size = new System.Drawing.Size(87, 17);
            this.rbRapido.TabIndex = 7;
            this.rbRapido.TabStop = true;
            this.rbRapido.Text = "Prato Rápido";
            this.rbRapido.UseVisualStyleBackColor = true;
            // 
            // rbAte30
            // 
            this.rbAte30.AutoSize = true;
            this.rbAte30.Location = new System.Drawing.Point(30, 501);
            this.rbAte30.Name = "rbAte30";
            this.rbAte30.Size = new System.Drawing.Size(95, 17);
            this.rbAte30.TabIndex = 8;
            this.rbAte30.TabStop = true;
            this.rbAte30.Text = "Até 30 minutos";
            this.rbAte30.UseVisualStyleBackColor = true;
            // 
            // rb30a60
            // 
            this.rb30a60.AutoSize = true;
            this.rb30a60.Location = new System.Drawing.Point(30, 532);
            this.rb30a60.Name = "rb30a60";
            this.rb30a60.Size = new System.Drawing.Size(128, 17);
            this.rb30a60.TabIndex = 9;
            this.rb30a60.TabStop = true;
            this.rb30a60.Text = "Entre 30 e 60 minutos";
            this.rb30a60.UseVisualStyleBackColor = true;
            // 
            // rbMais60
            // 
            this.rbMais60.AutoSize = true;
            this.rbMais60.Location = new System.Drawing.Point(30, 563);
            this.rbMais60.Name = "rbMais60";
            this.rbMais60.Size = new System.Drawing.Size(96, 17);
            this.rbMais60.TabIndex = 10;
            this.rbMais60.TabStop = true;
            this.rbMais60.Text = "Mais de 60 min";
            this.rbMais60.UseVisualStyleBackColor = true;
            // 
            // cbVegetariano
            // 
            this.cbVegetariano.AutoSize = true;
            this.cbVegetariano.Location = new System.Drawing.Point(33, 117);
            this.cbVegetariano.Name = "cbVegetariano";
            this.cbVegetariano.Size = new System.Drawing.Size(83, 17);
            this.cbVegetariano.TabIndex = 11;
            this.cbVegetariano.Text = "Vegetariano";
            this.cbVegetariano.UseVisualStyleBackColor = true;
            // 
            // cbVegano
            // 
            this.cbVegano.AutoSize = true;
            this.cbVegano.Location = new System.Drawing.Point(33, 151);
            this.cbVegano.Name = "cbVegano";
            this.cbVegano.Size = new System.Drawing.Size(63, 17);
            this.cbVegano.TabIndex = 12;
            this.cbVegano.Text = "Vegano";
            this.cbVegano.UseVisualStyleBackColor = true;
            // 
            // cbSemLactose
            // 
            this.cbSemLactose.AutoSize = true;
            this.cbSemLactose.Location = new System.Drawing.Point(33, 185);
            this.cbSemLactose.Name = "cbSemLactose";
            this.cbSemLactose.Size = new System.Drawing.Size(88, 17);
            this.cbSemLactose.TabIndex = 13;
            this.cbSemLactose.Text = "Sem Lactose";
            this.cbSemLactose.UseVisualStyleBackColor = true;
            // 
            // cbSemGluten
            // 
            this.cbSemGluten.AutoSize = true;
            this.cbSemGluten.Location = new System.Drawing.Point(33, 219);
            this.cbSemGluten.Name = "cbSemGluten";
            this.cbSemGluten.Size = new System.Drawing.Size(81, 17);
            this.cbSemGluten.TabIndex = 14;
            this.cbSemGluten.Text = "Sem Gluten";
            this.cbSemGluten.UseVisualStyleBackColor = true;
            // 
            // rbAlmoco
            // 
            this.rbAlmoco.AutoSize = true;
            this.rbAlmoco.Location = new System.Drawing.Point(35, 284);
            this.rbAlmoco.Name = "rbAlmoco";
            this.rbAlmoco.Size = new System.Drawing.Size(60, 17);
            this.rbAlmoco.TabIndex = 15;
            this.rbAlmoco.TabStop = true;
            this.rbAlmoco.Text = "Almoço";
            this.rbAlmoco.UseVisualStyleBackColor = true;
            // 
            // rbCafeTarde
            // 
            this.rbCafeTarde.AutoSize = true;
            this.rbCafeTarde.Location = new System.Drawing.Point(33, 408);
            this.rbCafeTarde.Name = "rbCafeTarde";
            this.rbCafeTarde.Size = new System.Drawing.Size(93, 17);
            this.rbCafeTarde.TabIndex = 17;
            this.rbCafeTarde.TabStop = true;
            this.rbCafeTarde.Text = "Café da Tarde";
            this.rbCafeTarde.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(33, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Gerar Cardápio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbJantar
            // 
            this.rbJantar.AutoSize = true;
            this.rbJantar.Location = new System.Drawing.Point(35, 346);
            this.rbJantar.Name = "rbJantar";
            this.rbJantar.Size = new System.Drawing.Size(54, 17);
            this.rbJantar.TabIndex = 19;
            this.rbJantar.TabStop = true;
            this.rbJantar.Text = "Jantar";
            this.rbJantar.UseVisualStyleBackColor = true;
            // 
            // rbLancheManha
            // 
            this.rbLancheManha.AutoSize = true;
            this.rbLancheManha.Location = new System.Drawing.Point(30, 439);
            this.rbLancheManha.Name = "rbLancheManha";
            this.rbLancheManha.Size = new System.Drawing.Size(111, 17);
            this.rbLancheManha.TabIndex = 20;
            this.rbLancheManha.TabStop = true;
            this.rbLancheManha.Text = "Lanche da manhã";
            this.rbLancheManha.UseVisualStyleBackColor = true;
            // 
            // rbCeia
            // 
            this.rbCeia.AutoSize = true;
            this.rbCeia.Location = new System.Drawing.Point(32, 470);
            this.rbCeia.Name = "rbCeia";
            this.rbCeia.Size = new System.Drawing.Size(46, 17);
            this.rbCeia.TabIndex = 21;
            this.rbCeia.TabStop = true;
            this.rbCeia.Text = "Ceia";
            this.rbCeia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 631);
            this.Controls.Add(this.rbCeia);
            this.Controls.Add(this.rbLancheManha);
            this.Controls.Add(this.rbJantar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbCafeTarde);
            this.Controls.Add(this.rbAlmoco);
            this.Controls.Add(this.cbSemGluten);
            this.Controls.Add(this.cbSemLactose);
            this.Controls.Add(this.cbVegano);
            this.Controls.Add(this.cbVegetariano);
            this.Controls.Add(this.rbMais60);
            this.Controls.Add(this.rb30a60);
            this.Controls.Add(this.rbAte30);
            this.Controls.Add(this.rbRapido);
            this.Controls.Add(this.rbSobremesa);
            this.Controls.Add(this.rbCafe);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox Barra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbCafe;
        private System.Windows.Forms.RadioButton rbSobremesa;
        private System.Windows.Forms.RadioButton rbRapido;
        private System.Windows.Forms.RadioButton rbAte30;
        private System.Windows.Forms.RadioButton rb30a60;
        private System.Windows.Forms.RadioButton rbMais60;
        private System.Windows.Forms.CheckBox cbVegetariano;
        private System.Windows.Forms.CheckBox cbVegano;
        private System.Windows.Forms.CheckBox cbSemLactose;
        private System.Windows.Forms.CheckBox cbSemGluten;
        private System.Windows.Forms.RadioButton rbAlmoco;
        private System.Windows.Forms.RadioButton rbCafeTarde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbJantar;
        private System.Windows.Forms.RadioButton rbLancheManha;
        private System.Windows.Forms.RadioButton rbCeia;
    }
}

