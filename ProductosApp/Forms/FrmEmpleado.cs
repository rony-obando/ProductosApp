using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities.Empleados;
using Domain.Enums;
using Infrastructure.Empleados;

namespace ProductosApp.Forms
{
    public partial class FrmEmpleado : Form
    {
        EmpleadoModel emodel;
        int b=0;
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        public FrmEmpleado(EmpleadoModel e,int a)
        {
            e = new EmpleadoModel();
            InitializeComponent();
            emodel = e;
            b = a;
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            if (b == 1)
            {
                lblCateg.Visible = true;
                cmbCategDocent.Visible = true;
                lblHoras.Visible = false;
                nudHorasExtras.Visible = false;
            }
            else {
                lblCateg.Visible = false;
                cmbCategDocent.Visible = false;
                lblHoras.Visible = true;
                nudHorasExtras.Visible = true;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (b==1)
                {
                    Empleado emp = new Docente((int)nudCodigo.Value, txtCedula.Text, txtNombre.Text, txtApellidos.Text, nudSalario.Value, dtpFechContr.Value)
                    {
                        ID = (int)nudID.Value,
                        categoriaDocente=(CategoriaDocente)cmbCategDocent.SelectedIndex,
                    };
               emodel.Create(emp);
                    this.Close();
                }
                else
                {
                    Empleado emp = new Administrativo((int)nudCodigo.Value, txtCedula.Text, txtNombre.Text, txtApellidos.Text, nudSalario.Value, dtpFechContr.Value)
                    {
                        ID = (int)nudID.Value,
                        HorasExtras = (float)nudHorasExtras.Value,
                    };
                    emodel.Create(emp);
                    this.Close();
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
