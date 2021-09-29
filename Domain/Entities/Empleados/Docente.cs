using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities.Empleados
{
    public class Docente : Empleado
    {
        public CategoriaDocente categoriaDocente { get; set; }
        public Docente(int codigo, string cedula, string nombre, string apellidos, decimal salario, DateTime fechaContratacion) : base(codigo, cedula, nombre, apellidos, salario, fechaContratacion)
        {

        }

        public override string GetEmpleadoAsString()
        {
            return string.Format("{0,5:D}{1,20}{2,20}{3,20}{4,7:F}{5,20:D}{6,20}",$"{Codigo}", $"{Cedula}", $"{Nombre}", $"{Apellidos}", $"{Salario}", $"{FechaContratacion}", $"{categoriaDocente}");
        }
    }
}
