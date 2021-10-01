using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        /*public FrmEmpleado()
        {
            InitializeComponent();
        }*/
        public FrmEmpleado(EmpleadoModel e,int a)
        {
            emodel = new EmpleadoModel();
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
                ValidateDate();
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
        private void ValidateDate()
        {
            string patternDni = @"\d{3}-\d{6}-\d{4}[A-Z]{1}";
            if (b == 1)
            {
                if (string.IsNullOrEmpty(cmbCategDocent.Text))
                {
                    throw new ArgumentException("Error, Introduzca una categoria de docente");
                }
            }
            if (nudSalario.Value == 0)
            {
                throw new ArgumentException("Error, Introduzca un salario");
            }
            if (nudID.Value == 0)
            {
                throw new ArgumentException("Error, Introduzca un ID");
            }
            if (nudCodigo.Value == 0)
            {
                throw new ArgumentException("Error, Introduzca un codigo");
            }
            if (dtpFechContr.Value==DateTime.Now)
            {
                throw new ArgumentException("Error, Introduzca una fecha de contratación");
            }
            if (string.IsNullOrEmpty(txtCedula.Text)|| string.IsNullOrEmpty(txtApellidos.Text)|| string.IsNullOrEmpty(txtNombre.Text))
            {
                throw new ArgumentException("Error, todos los datos son requeridos");
            }
            if (!Regex.Match(txtCedula.Text, patternDni).Success)
            {
                throw new ArgumentException("Error, cedula no tiene el formato correcto [000-000000-0000U]");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64)||(e.KeyChar>=93&&e.KeyChar<=96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras");
                e.Handled=true;
                return;
            }
        }
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 93 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras");
                e.Handled = true;
                return;
            }
        }
    }
}
