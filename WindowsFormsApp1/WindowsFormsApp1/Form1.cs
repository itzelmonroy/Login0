using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton_Click(object sender, EventArgs e)
        {
            string usuario, contra;
            usuario = UsuarioTextBox.Text;
            contra = contraseñatextBox.Text;
            if (usuario == "juancho" & contra == "123tamarindo")
            {
                MessageBox.Show("Bienvenido juancho");
            }
            else
            {
                MessageBox.Show("Fuchi no eres juancho");
            }

        }
    }
}
