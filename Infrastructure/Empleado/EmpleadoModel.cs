using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Empleados;

namespace Infrastructure.Empleado
{
    public class EmpleadoModel
    {
        private Empleado[] empleados;
        public void Create(Empleado e)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                return;
            }

            Empleado[] tmp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados,tmp,empleados.Length);
            tmp[tmp.Length - 1] = e;
            empleados = tmp;
        }
        public int GetlastEmpleadoId()
        {
            return empleados == null ? 0 : empleados[empleados.Length - 1].Id;
        }
        public Empleado[] GetEmpleados()
        {
            return empleados;
        }
    }
}
