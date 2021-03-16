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
    public partial class recargar : Form
    {
        public recargar()
        {
            InitializeComponent();
           
        }

        private void recargar_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numero_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            Form recargar = new ininre();
            recargar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form recargar = new perfil();
            recargar.ShowDialog();
        }
    }
}
