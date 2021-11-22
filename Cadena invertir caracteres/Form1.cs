using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadena_invertir_caracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCadena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            string mostar = this.txtCadena.Text;
            string conta = "";
            for (int x = mostar.Length-1; x>= 0 ;x--)
            {
                conta = conta + mostar[x];
                
            }
            this.txtRes.Text = conta.ToString();
        }
    }
}
