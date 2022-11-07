namespace Exercicio_Matematica
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.NumericUpDown();
            this.txbN2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(287, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo da Area";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(124, 142);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(52, 24);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Base";
            this.lblN1.Click += new System.EventHandler(this.lblN1_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(124, 173);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(58, 24);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Altura";
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(219, 140);
            this.txbN1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txbN1.Minimum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            -2147483648});
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(120, 20);
            this.txbN1.TabIndex = 3;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(219, 171);
            this.txbN2.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txbN2.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(120, 20);
            this.txbN2.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(170, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 51);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(151, 365);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(148, 20);
            this.txbResultado.TabIndex = 6;
            this.txbResultado.Tag = "";
            this.txbResultado.TextChanged += new System.EventHandler(this.txbResultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Teal;
            ((System.ComponentModel.ISupportInitialize)(this.txbN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.NumericUpDown txbN1;
        private System.Windows.Forms.NumericUpDown txbN2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label label1;
    }
}

