using Domain.Entities.Empleados;
using Infrastructure.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmEmpleados : Form
    {
        private EmpleadoModel empleadoModel;
        public FrmEmpleados()
        {
            empleadoModel = new EmpleadoModel();

            InitializeComponent();
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            Empleado emp = new Docente(100, "001-000000-0000U", "Pepito Jose", "Perez Zosa", 23789.98M, DateTime.Now) {
                categoriaDocente = Domain.Enums.CategoriaDocente.Titular,
                ID=empleadoModel.GetlastEmpleadoId()+1
            };

            empleadoModel.Create(emp);
            PrintEmpleado();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Empleado emp = new Administrativo(100, "001-000000-0000U", "Maria Jose", "Obando Rodriguez", 23789.98M, DateTime.Now)
            {
                HorasExtras=23.5f,
                ID = empleadoModel.GetlastEmpleadoId() + 1
            };

            empleadoModel.Create(emp);
            PrintEmpleado();
        }
        private void PrintEmpleado()
        {
            Empleado[] empleados = empleadoModel.GetEmpleados();
            if (empleados == null)
            {
                MessageBox.Show("Esta Vacio");
                return;
            }
            foreach(Empleado e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
            }
        }
    }
}
