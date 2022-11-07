using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblN1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txbN1.Value.ToString());
            double y = double.Parse(txbN1.Value.ToString());
            double calculo = (x * y / 2);

            txbResultado.Text = calculo.ToString();
          
            
        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {
            //Declara as variaveis dos numeros estabelecidos
            double x = double.Parse(txbN1.Value.ToString());
            double y = double.Parse(txbN1.Value.ToString());
            double calculo = (x * y / 2);

            //Calculo da area: e mostrar o resultado na txbResultado
            txbResultado.Text = calculo.ToString();

     
          
        }


       
        
    }
}
