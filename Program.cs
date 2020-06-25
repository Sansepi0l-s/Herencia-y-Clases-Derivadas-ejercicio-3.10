using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Pablo de Tarso", "111-11-1111",800.00M);
            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("Karen Price", "222-22-2222", 16.75M,
            40.0M);
            EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision("Sue Jones", "333-33-3333",
            10000.00M, .06M);
            EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision("Bob Lewis",
            "444-44-4444", 5000.00M, .04M, 300.00M);
            // crea arreglo Empleado de cuatro elementos
            Empleado[] empleados = new Empleado[4];
            // inicializa arreglo con objetos Empleado de tipos derivados
            empleados[0] = empleadoAsalariado;
            empleados[1] = empleadoPorHoras;
            empleados[2] = empleadoPorComision;
            empleados[3] = empleadoBaseMasComision;
            Console.WriteLine("Empleados procesados en forma polimórfica:\n");
            // procesa en forma generica cada elemento en el arreglo de empleados
            foreach (Empleado empleadoActual in empleados)
            {
                empleadoActual.Imprimir();
                // determina si el elemento es un EmpleadoBaseMasComision
                if (empleadoActual is EmpleadoBaseMasComision)
                {
                    // conversión descendente de referencia de Empleado a referencia de EmpleadoBaseMasComision
                    EmpleadoBaseMasComision empleado = (EmpleadoBaseMasComision)empleadoActual;
                    empleado.SalarioBase *= 1.10M;
                    Console.WriteLine("nuevo salario base con incremento del 10%:{0:F2}", empleado.SalarioBase);
                }
                Console.WriteLine("ingresos {0:F2}\n", empleadoActual.Ingresos());
            } // fin de foreach
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

    }
}
