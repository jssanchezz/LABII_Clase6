using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Ferrete_Construccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            int largo;
            int ancho;
            int alambrado;

            largo = int.Parse(this.txtLargo.Text);
            ancho = int.Parse(this.txtAncho.Text);

            alambrado = (largo * 6) + (ancho * 6);

            MessageBox.Show(alambrado.ToString());
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double radio;
            double alambrado;

            radio = double.Parse(this.txtRadio.Text);

            alambrado = (radio * 2) * 3.14;

            MessageBox.Show(alambrado.ToString());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            int largo;
            int ancho;
            int cemento;
            int cal;

            largo = int.Parse(this.txtLargo.Text);
            ancho = int.Parse(this.txtAncho.Text);

            cemento = (largo * ancho) * 2;
            cal = (largo * ancho) * 3;

            MessageBox.Show("Bolsas de cemento : " + cemento.ToString() );
            MessageBox.Show("\nBolsas de cal: " + cal.ToString());
        }
    }
}
