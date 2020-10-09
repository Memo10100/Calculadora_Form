using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Calculadora_Inmueble
{
    class Local_Comercial : Inmueble
    {
        int Numero_De_Ventanas = 0;
        public Local_Comercial(bool inmueble_Estado, int Numero_De_Ventanas , double m2, double precio_Base, string direccion) : base(inmueble_Estado, m2, precio_Base, direccion)
        {
            this.Numero_De_Ventanas = Numero_De_Ventanas;
        }

        public override double Calcular_Precio()
        {
            double Precio_Tazado = 0.0, A = 0.0, B = 0.0, C = 0.0;

            //para cualquier inmueble, si tiene menos de 15 años, su precio se rebaja un 1 %
            if (Inmueble_Estado == true)
                A -= (Precio_Base * 0.01);
            else
            //mientras que si tiene más se reduce un 2 %
                A -= (Precio_Base * 0.02);

            //para los locales comerciales, si tiene mas de 50 metros cuadrados, su precio se incrementa un 1 %
            if (m2 > 50)
                B += (Precio_Base * 0.01);
            //para los locales comerciales,si tiene 1 ventana o menos, su precio se descrementa un 1 %
            if (Numero_De_Ventanas <= 1)
                C -= (Precio_Base * 0.02);
            //para los locales comerciales,si tiene mas de 4 ventana , su precio se incrementa un 2 %
            else if (Numero_De_Ventanas >= 4)
                C += (Precio_Base * 0.02);

            Precio_Tazado = Precio_Base + A + B + C;

            return Precio_Tazado;
        }

    }
}
