using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string aux;

            aux = this.txtNombre.Text;

            MessageBox.Show(aux);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.labelNombre.Text = "Cambie el texto";
        }

        private void btnAprobarMateria_Click(object sender, EventArgs e)
        {

        }

        private void btnAprobarMateria_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnAprobarMateria_MouseLeave(object sender, EventArgs e)
        {
            //this.btnAprobarMateria.Visible
        }

        private void btnAprobarMateria_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = true;
        }
    }
}
