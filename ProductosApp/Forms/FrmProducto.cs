using Domain.Entities;
using Domain.Enums;
using Infrastructure.Productos;
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
    public partial class FrmProducto : Form
    {
        public ProductoModel PModel;
        public FrmProducto()
        {
            PModel = new ProductoModel();
            InitializeComponent();
        }
        int a = 0;
        public Producto[] pst;
        public FrmProducto(ProductoModel p,int a)
        {
            PModel = new ProductoModel();
            this.a = a;
            InitializeComponent();
            this.PModel = p;
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
            FrmProductos frmProducto = new FrmProductos();
            if (a == 1)
            {
                label2.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                txtNombre.Visible = false;
                nudExistencia.Visible = false;
                nudPrecio.Visible = false;
                dtpCaducidad.Visible = false;
                cmbUnidadMedida.Visible = false;
                txtNombre.Visible = false;
                rtbDescripcion.Visible = false;
                groupBox1.Text = "ID del Producto";
            }

        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ValidateProducto()
        {
            
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                throw new ArgumentException("Error, No ha ingresado nada en el Nombre");
            }
            if(nudID.Value == 0)
            {
                throw new ArgumentException("Error, No ha ingresado nada en el ID");
            }
            if (nudExistencia.Value == 0)
            {
                throw new ArgumentException("Error, No ha ingresado nada en las Existencias");
            }
            if (string.IsNullOrWhiteSpace(cmbUnidadMedida.Text))
            {
                throw new ArgumentException("Error, No ha seleccionado nada en las unidades de medida");
            }
            if (nudPrecio.Value == 0)
            {
                throw new ArgumentException("Error, No ha ingresado nada en el precio");
            }
            if (string.IsNullOrWhiteSpace(rtbDescripcion.Text))
            {
                throw new ArgumentException("Error, No ha ingresado nada en la descripción");
            }
            if (txtNombre.Text.Length > 25)
            {
                throw new ArgumentException("Error, maximo de caracteres permitidos en nombre es 25");
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (a == 0)
                {
                    ValidateProducto();
                    Producto P = new Producto()
                    {
                        ID = (int)nudID.Value,
                        Nombre = txtNombre.Text,
                        Descripcion = rtbDescripcion.Text,
                        Existencia = (int)nudExistencia.Value,
                        Precio = nudPrecio.Value,
                        Vencimiento = dtpCaducidad.Value,
                        UnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedIndex

                    };
                    PModel.Add(P);
                    Dispose();
                    
                }
                else if (a == 2)
                {
                    ValidateProducto();
                    Producto P2 = new Producto()
                    {
                        ID = (int)nudID.Value,
                        Nombre = txtNombre.Text,
                        Descripcion = rtbDescripcion.Text,
                        Existencia = (int)nudExistencia.Value,
                        Precio = nudPrecio.Value,
                        Vencimiento = dtpCaducidad.Value,
                        UnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedIndex
                    };
                    PModel.Update(P2);
                    Dispose();
                }else if(a == 1){
                    Producto P2 = new Producto()
                    {
                        ID = (int)nudID.Value,
                    };
                    PModel.Delete(P2);
                    Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
