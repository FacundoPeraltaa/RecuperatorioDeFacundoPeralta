using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEjercicioMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numero1;
        private int numero2;
        private void MultiplicarButton1_Click(object sender, EventArgs e)
        {
            numero1 = int.Parse(Numero1TextBox.Text);
            numero2 = int.Parse(Numero2TextBox.Text);
            var Multiplicar = numero1 * numero2;
            MessageBox.Show(Multiplicar.ToString(), " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
  

            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            Numero1TextBox.Focus();
        }




                private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
