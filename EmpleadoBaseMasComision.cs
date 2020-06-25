using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        private decimal salarioBase; // salario base por semana
        public EmpleadoBaseMasComision() { }
        public EmpleadoBaseMasComision(string nombre, string nss, decimal ventas, decimal tarifa,
        decimal salario)
            : base(nombre, nss, ventas, tarifa)
        {
            SalarioBase = salario; // valida el salario base a través de una propiedad
        }
        public decimal SalarioBase
        {
            get { return salarioBase; }
            set
            {
                salarioBase = (value >= 0) ? value : 0; // validación}
            }
        }
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }
        public override void Imprimir()
        {
            Console.WriteLine("Empleado base más comisión");
            base.Imprimir();
            Console.WriteLine("Salario base " + SalarioBase);
        }
    }
}
