using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal;
        public EmpleadoAsalariado() { }
        // constructor con cuatro parámetros
        public EmpleadoAsalariado(string nombre, string nss, decimal salario)
            : base(nombre, nss)
        {
            SalarioSemanal = salario; // valida el salario a través de una propiedad
        }
        // propiedad que obtiene y establece el salario del empleado asalariado
        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }
            set
            {
                salarioSemanal = ((value >= 0) ? value : 0); // validación
            }
        }
        // calcula los ingresos; redefine el método abstracto Ingresos en Empleado
        public override decimal Ingresos()
        {
            return SalarioSemanal;
        }
        // Imprime los datos de EmpleadoAsalariado
        public override void Imprimir()
        {
            Console.WriteLine("empleado asalariado");
            base.Imprimir();
            Console.WriteLine("salario semanal" + SalarioSemanal);
        }
    }
}
