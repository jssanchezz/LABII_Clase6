using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaC_Click(object sender, EventArgs e)
        {
            double centigrados;
            double farenheit;

            farenheit = double.Parse(this.txtTemperatura.Text);

            
        }
    }
}
