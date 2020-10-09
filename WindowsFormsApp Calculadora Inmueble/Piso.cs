using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Calculadora_Inmueble
{
    class Piso : Inmueble
    {

        public int Numero_De_Pisos = 0;

        public Piso(bool inmueble_Estado, double m2,int Numero_De_Pisos , double precio_Base, string direccion) : base(inmueble_Estado, m2, precio_Base, direccion)
        {
            this.Numero_De_Pisos = Numero_De_Pisos;
        }

        public override double Calcular_Precio()
        {

            double Precio_Tazado = 0.0, A = 0.0, B = 0.0;

            //para cualquier inmueble, si tiene menos de 15 años, su precio se rebaja un 1 %
            if (Inmueble_Estado == true)
                A -= (Precio_Base * 0.01);
            else
            //mientras que si tiene más se reduce un 2 %
                A -= (Precio_Base * 0.02);

            //para pisos si esta en un piso 3 o superior, su precio se incrementa en un 3%
            if (Numero_De_Pisos >= 3)
                B += (Precio_Base * 0.03);

            Precio_Tazado = Precio_Base + A + B;

            return Precio_Tazado;

        }
    }
}
