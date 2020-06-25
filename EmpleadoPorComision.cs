using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    public class EmpleadoPorComision : Empleado
    {

        private decimal ventasBrutas;
        private decimal tarifaComision;
        public EmpleadoPorComision() { }
        // constructor
        public EmpleadoPorComision(string nombre, string nss, decimal ventas, decimal tarifa)
            : base(nombre, nss)
        {
            VentasBrutas = ventas;
            TarifaComision = tarifa;
        }
        public decimal VentasBrutas
        {
            set { ventasBrutas = (value < 0) ? 0 : value; }
            get { return ventasBrutas; }
        }
        public decimal TarifaComision
        {
            set { tarifaComision = (value > 0 && value < 1) ? value : 0; }
            get { return tarifaComision; }
        }
        // calcula los ingresos
        public override decimal Ingresos()
        {
            return (TarifaComision * VentasBrutas);
        }
        // Implementación del método heredado
        public override void Imprimir()
        {
            Console.WriteLine("Empleado por comision");
            base.Imprimir();
            Console.WriteLine("Ventas brutas: {0:F2}", VentasBrutas);
            Console.WriteLine("Tarifa de comisión: {0:F2}", TarifaComision);
        }
    }
}
