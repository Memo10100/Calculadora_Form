using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculadora_Inmueble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool inmueble_Estado;
            string Direccion;
            double M2 = 0.0;
            double Precio_Base = 0.0;
            int Numero_De_Piso = 0;
            int Numero_De_ventanas = 0;



            Direccion = textBoxDI.Text;
            M2 = Convert.ToDouble(textBoxM2.Text);
            Precio_Base = Convert.ToDouble(textBoxPrecioBase.Text);
            Numero_De_Piso = Convert.ToInt32(textBoxNumeroDePisos.Text);
            Numero_De_ventanas = Convert.ToInt32(textBoxNumeroDeVentanas.Text);


            Piso P = new Piso(radioButtonNuevo.Checked.Equals(true), M2, Numero_De_Piso, Precio_Base, Direccion);

            Local_Comercial LC = new Local_Comercial(radioButtonNuevo.Checked.Equals(true), Numero_De_ventanas, M2, Precio_Base, Direccion);
            
            if (radioButtonPiso.Checked == true)
            {
                textBoxPrecioTazado.Text = Convert.ToString(P.Calcular_Precio());
            }

            if (radioButtonLC.Checked == true)
            {
                textBoxPrecioTazado.Text = Convert.ToString(LC.Calcular_Precio());
            }



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPiso.Checked == true)
            {
                textBoxNumeroDeVentanas.Enabled = false;
                textBoxNumeroDePisos.Enabled = true;
            }

        }

        private void radioButtonLC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLC.Checked == true)
            {
                textBoxNumeroDePisos.Enabled = false;
                textBoxNumeroDeVentanas.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNuevo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioTazado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
