
namespace Projeto51Fellipe2._0
{
    partial class FormDetalheReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.flowIngredientes = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.lblModoPrep = new System.Windows.Forms.Label();
            this.exibIngredientes = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(87, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto51Fellipe2._0.Properties.Resources.sem_foto;
            this.pictureBox1.Location = new System.Drawing.Point(629, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(89, 139);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(35, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "label2";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(410, 139);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(35, 13);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "label3";
            // 
            // flowIngredientes
            // 
            this.flowIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowIngredientes.Location = new System.Drawing.Point(89, 319);
            this.flowIngredientes.Name = "flowIngredientes";
            this.flowIngredientes.Size = new System.Drawing.Size(374, 350);
            this.flowIngredientes.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Location = new System.Drawing.Point(89, 232);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(35, 13);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.Text = "label4";
            // 
            // lblModoPrep
            // 
            this.lblModoPrep.AutoSize = true;
            this.lblModoPrep.Location = new System.Drawing.Point(639, 286);
            this.lblModoPrep.Name = "lblModoPrep";
            this.lblModoPrep.Size = new System.Drawing.Size(35, 13);
            this.lblModoPrep.TabIndex = 6;
            this.lblModoPrep.Text = "label4";
            // 
            // exibIngredientes
            // 
            this.exibIngredientes.AutoSize = true;
            this.exibIngredientes.Location = new System.Drawing.Point(89, 286);
            this.exibIngredientes.Name = "exibIngredientes";
            this.exibIngredientes.Size = new System.Drawing.Size(68, 13);
            this.exibIngredientes.TabIndex = 7;
            this.exibIngredientes.Text = "Ingredientes:";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(410, 232);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(35, 13);
            this.lblCalorias.TabIndex = 8;
            this.lblCalorias.Text = "label1";
            // 
            // FormDetalheReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 760);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.exibIngredientes);
            this.Controls.Add(this.lblModoPrep);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.flowIngredientes);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNome);
            this.Name = "FormDetalheReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalheReceita";
            this.Load += new System.EventHandler(this.FormDetalheReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.FlowLayoutPanel flowIngredientes;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.Label lblModoPrep;
        private System.Windows.Forms.Label exibIngredientes;
        private System.Windows.Forms.Label lblCalorias;
    }
}