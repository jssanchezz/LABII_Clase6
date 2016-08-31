using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Ferrete_Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int precio1;
            int precio2;
            int precio3;
            int resultado;

            precio1 = int.Parse(this.txtPrecio1.Text);
            precio2 = int.Parse(this.txtPrecio2.Text);
            precio3 = int.Parse(this.txtPrecio3.Text);

            resultado = precio1 + precio2 + precio3;

            MessageBox.Show(resultado.ToString());

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int precio1;
            int precio2;
            int precio3;
            int resultado;

            precio1 = int.Parse(this.txtPrecio1.Text);
            precio2 = int.Parse(this.txtPrecio2.Text);
            precio3 = int.Parse(this.txtPrecio3.Text);

            resultado = (precio1 + precio2 + precio3)/3;

            MessageBox.Show(resultado.ToString());
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            int precio1;
            int precio2;
            int precio3;
            int total;
            int IVA;
            int resultado;

            precio1 = int.Parse(this.txtPrecio1.Text);
            precio2 = int.Parse(this.txtPrecio2.Text);
            precio3 = int.Parse(this.txtPrecio3.Text);

            total = precio1 + precio2 + precio3;

            IVA = (total * 21) / 100;

            resultado = total + IVA;

            MessageBox.Show(resultado.ToString());
        }
    }
}
