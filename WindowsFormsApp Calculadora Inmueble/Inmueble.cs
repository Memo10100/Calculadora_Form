using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Calculadora_Inmueble
{
    public abstract class Inmueble
    {


        protected bool Inmueble_Estado;
        protected double m2 = 0.0;
        protected double Precio_Base = 0.0;
        protected string Direccion;

        public Inmueble(bool inmueble_Estado, double m2, double precio_Base, string direccion)
        {
            Inmueble_Estado = inmueble_Estado;
            this.m2 = m2;
            Precio_Base = precio_Base;
            Direccion = direccion;
        }

        public virtual double Calcular_Precio()
        {

            double Precio_Tazado = 0.0;

            Precio_Tazado = Precio_Base;

            //para cualquier inmueble, si tiene menos de 15 años, su precio se rebaja un 1 %

            if (Inmueble_Estado == true)
            {
                Precio_Tazado -= (Precio_Base * .01);
            }

            //mientras que si tiene más se reduce un 2 %

            if (Inmueble_Estado == false)
            {
                Precio_Tazado -= (Precio_Base * .02);
            }

            return Precio_Tazado;
        }
        

    }
}
