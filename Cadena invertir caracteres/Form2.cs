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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.txtIngresar.Text;
            int cont = 0;
            char espacio = ' ';

            for (int i = 0; i < input.Length; i++)
            {

                if ((input[i] == ' ' && espacio != ' ') || (i == input.Length - 1 && input[i] != ' '))
                {


                    cont++;

                }
                espacio = input[i];
            }
            this.txtResul.Text = cont.ToString();
        }
    }
}
