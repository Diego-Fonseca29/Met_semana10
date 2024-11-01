using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazPaciente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxname.Clear();
            textBoxapellido.Clear();
            textBoxConsulta.Clear();
            checkBoxAlergias.Checked = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interfaz hecho por Farid Zúñiga Rico");
            Close();
        }
    }
}
