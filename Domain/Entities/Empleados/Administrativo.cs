using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Empleados
{
    public class Administrativo:Empleado
    {
        public float HorasExtras { get; set; }
        public Administrativo(int codigo, string cedula, string nombre, string apellidos, decimal salario, DateTime fechaContratacion) : base(codigo, cedula, nombre, apellidos, salario, fechaContratacion)
        {

        }
        public override string GetEmpleadoAsString()
        {
            return string.Format("{0,5:D}{1,5:D}{2,20}{3,20}{4,30}{5,7:F}{6,20:D}{7,20:F} \n", $"{ID}", $"{Codigo}", $"{Cedula}", $"{Nombre}", $"{Apellidos}", $"{Salario}", $"{FechaContratacion}", $"{HorasExtras}");
        }
    }
}
