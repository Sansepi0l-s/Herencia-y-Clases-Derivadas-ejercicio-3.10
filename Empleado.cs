using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_3
{
    public abstract class Empleado
    {
        private string nombre;
        private string numeroSeguroSocial;
        public Empleado() { }
        // constructor con argumentos
        public Empleado(string nombre, string nss)
        {
            this.nombre = nombre;
            this.numeroSeguroSocial = nss;
        }
        // propiedad de solo lectura que obtiene el primer nombre del empleado
        public string Nombre { get { return nombre; } }
        // propiedad de solo lectura que obtiene el nÃºmero de seguro social del empleado
        public string NumeroSeguroSocial { get { return numeroSeguroSocial; } }
        // Imprime los datos de un empleado
        public virtual void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Numero de seguro social: " + NumeroSeguroSocial);
        }
        public abstract decimal Ingresos();
    }
}
