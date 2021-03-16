using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class ininre : Form
    {
        public ininre()
        {
            InitializeComponent();
        }

        private void ininre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

   
    

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            Form inicio = new recargar();
            inicio.ShowDialog();

        }
        private void olvidocontra_Click(object sender, EventArgs e)
        {

        }

        private void olvido_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void olvicontra_Click(object sender, EventArgs e)
        {
            Form inicio = new contra();
            inicio.ShowDialog();
        }

        private void creacion_Click(object sender, EventArgs e)
        {
            Form inicio = new crear_cuenta();
            inicio.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form inicio = new recargar();
            inicio.ShowDialog();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Form inicio = new recargar();
            inicio.ShowDialog();
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            
                Application.Exit();
            }
        
    }
}
