using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
    public abstract class Empleado
    {
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }

        protected Empleado(int codigo, string cedula, string nombre, string apellidos, decimal salario, DateTime fechaContratacion)
        {
            Codigo = codigo;
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = fechaContratacion;
        }
        public abstract string GetEmpleadoAsString();
        
    }
}
