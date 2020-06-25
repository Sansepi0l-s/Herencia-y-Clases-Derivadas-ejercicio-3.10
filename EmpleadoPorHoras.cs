using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    public class EmpleadoPorHoras : Empleado
    {
        //Clase derivada EmpleadoPorHoras.
        private decimal sueldo; // sueldo por hora
        private decimal horas; // horas trabajadas durante la semana
        public EmpleadoPorHoras() { }
        public EmpleadoPorHoras(string nombre, string nss, decimal sueldoPorHoras,
        decimal horasTrabajadas)
            : base(nombre, nss)
        {
            Sueldo = sueldoPorHoras; // valida el sueldo por horas a través de una propiedad
            Horas = horasTrabajadas; // valida las horas trabajadas a través de una propiedad
        }
        // propiedad que obtiene y establece el sueldo del empleado por horas
        public decimal Sueldo
        {
            get { return sueldo; }
            set
            {
                sueldo = (value >= 0) ? value : 0; // validación }
            }
        }
        // propiedad que obtiene y establece las horas del empleado por horas
        public decimal Horas
        {
            get { return horas; }
            set
            {
                horas = ((value >= 0) && (value <= 168)) ? value : 0; // validación }
            }
        }
        // calcula los ingresos; redefine el método abstracto Ingresos de Empleado
        public override decimal Ingresos()
        {
            if (Horas <= 40) // no hay tiempo extra
                return Sueldo * Horas;
            else
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
        }
        public override void Imprimir()
        {
            Console.WriteLine("Empleado por horas");
            base.Imprimir();
            Console.WriteLine("Sueldo: {0:F2}", Sueldo);
            Console.WriteLine("Horas trabajadas {0:F2}", Horas);
        }
    }
}
