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
            FrmEmpleado si = new FrmEmpleado(empleadoModel,1);
            si.ShowDialog();
            
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            /*Empleado emp = new Administrativo(100, "001-000000-0000U", "Maria Jose", "Obando Rodriguez", 23789.98M, DateTime.Now)
            {
                HorasExtras=23.5f,
                ID = empleadoModel.GetlastEmpleadoId() + 1
            };

            empleadoModel.Create(emp);*/
            FrmEmpleado si = new FrmEmpleado(empleadoModel, 0);
            si.ShowDialog();
            
        }
        private void PrintEmpleado()
        {
            Empleado[] empleados = empleadoModel.GetEmpleados();
            if (empleados == null)
            {
                MessageBox.Show("No se ha ingresado datos");
                return;
            }
            richTextBox1.Text = "";
            foreach(Empleado e in empleados)
            {
                richTextBox1.AppendText(e.GetEmpleadoAsString());
            }
        }
        

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            PrintEmpleado();
        }
    }
}
