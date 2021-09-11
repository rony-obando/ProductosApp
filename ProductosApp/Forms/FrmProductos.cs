using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Infrastructure.Productos;
using Domain.Entities;

namespace ProductosApp.Forms
{
    public partial class FrmProductos : Form
    {
        private ProductoModel productoModel;
        public FrmProductos()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }
       

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nubRangeHigher_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbUnitMeasur.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
        }

        private void cmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFinderType.SelectedIndex == 0)
            {
                dtpFinder.Visible = false;
                txtFinder.Visible = true;
                cmbUnitMeasur.Visible = false;
                nubRangeHigher.Visible = false;
                nubRangeLess.Visible = false;
                lblRangMn.Visible = false;
                lblRangMy.Visible = false;
            }
            else if (cmbFinderType.SelectedIndex == 1)
            {
                dtpFinder.Visible = false;
                cmbUnitMeasur.Visible = false;
                txtFinder.Visible = false;
                nubRangeHigher.Visible = true;
                nubRangeLess.Visible = true;
                lblRangMn.Visible = true;
                lblRangMy.Visible = true;
            }
            else if (cmbFinderType.SelectedIndex == 2)
            {
                dtpFinder.Visible = true;
                txtFinder.Visible = false;
                cmbUnitMeasur.Visible = false;
                nubRangeHigher.Visible = false;
                nubRangeLess.Visible = false;
                lblRangMn.Visible = false;
                lblRangMy.Visible = false;
            }
            else if (cmbFinderType.SelectedIndex == 3)
            {
                dtpFinder.Visible = false;
                txtFinder.Visible = false;
                cmbUnitMeasur.Visible = true;
                nubRangeHigher.Visible = false;
                nubRangeLess.Visible = false;
                lblRangMn.Visible = false;
                lblRangMy.Visible = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProducto = new FrmProducto();
            frmProducto.PModel=productoModel;
            frmProducto.ShowDialog();
            string v = productoModel.GetProductosAsJson();
            string a = v;
            rtbProductView.Text=a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Mostrar(Producto[] a)
        {
            string mostrar="";
            if (productoModel.productos == null)
            {
                throw new ArgumentException("Error, No ha ingresado productos.");
            }
            foreach (Producto P in a)
            {
                mostrar = $@"Codigo: {P.ID}{Environment.NewLine}
Nombre: {P.Nombre}{Environment.NewLine}
Descripción: {P.Descripcion}{Environment.NewLine}
Existencias: {P.Existencia}{Environment.NewLine}
Precio: {P.Precio}{Environment.NewLine}
Caducidad: {P.Vencimiento}{Environment.NewLine}
Unidad de medida: {P.UnidadMedida}{Environment.NewLine}{Environment.NewLine}" + mostrar;
            }
            rtbProductView.Text = "";
            rtbProductView.Text = mostrar;
        }
        private void Mostrar(Producto P)
        {
            string mostrar = "";
                mostrar = $@"Codigo: {P.ID}{Environment.NewLine}
Nombre: {P.Nombre}{Environment.NewLine}
Descripción: {P.Descripcion}{Environment.NewLine}
Existencias: {P.Existencia}{Environment.NewLine}
Precio: {P.Precio}{Environment.NewLine}
Caducidad: {P.Vencimiento}{Environment.NewLine}
Unidad de medida: {P.UnidadMedida}{Environment.NewLine}{Environment.NewLine}" + mostrar;
            rtbProductView.Text = "";
            rtbProductView.Text = mostrar;
        }
        private void Validatedate()
        {
            switch (cmbFinderType.SelectedIndex)
            {

                case 0:
                    if (txtFinder.Text == "")
                    {
                        throw new ArgumentException("Error, no ha ingresado el ID");
                    }
                    
                    if (!int.TryParse(txtFinder.Text, out int a))
                    {
                        throw new ArgumentException($"Error, esto: {txtFinder.Text} no es un numero entero");
                    }
                    return;
                case 3:
                    if (cmbUnitMeasur.Text=="")
                    { 
                        throw new ArgumentException("Error, no ha ingresado la unidad de medida");
                    }
                    return;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFinderType.Text == "")
                {
                    throw new ArgumentException("Error, No ha seleccionado por que desea buscar");
                }
                Validatedate();
                switch (cmbFinderType.SelectedIndex)
                {
                    case 0:
                        vacio();
                        if (productoModel.GetProductoById(int.Parse(txtFinder.Text)) == null)
                        {
                            throw new ArgumentException("Error, no se ha encontrado un producto con ese codigo");
                        }
                        Producto pt = productoModel.GetProductoById(int.Parse(txtFinder.Text));
                        Mostrar(pt);
                        break;
                    case 1:
                        vacio();
                        if (nubRangeLess.Value > nubRangeHigher.Value)
                        {
                            throw new ArgumentException("Error,el rango mayor es menor que el rango menor");
                        }
                        if (productoModel.GetProductosByRangoPrecio(nubRangeLess.Value, nubRangeHigher.Value) == null)
                        {
                            throw new ArgumentException("Error, no se ha encontrado un producto con ese codigo");
                        }
                        Producto[] pt1 = productoModel.GetProductosByRangoPrecio(nubRangeLess.Value, nubRangeHigher.Value);
                        Mostrar(pt1);
                        break;
                    case 2:
                        vacio();
                        Producto[] pt2=productoModel.GetProductosByCaducidad(dtpFinder.Value);
                        Mostrar(pt2);
                        break;
                    case 3:
                        vacio();
                        Producto[] pt3 = productoModel.GetProductosByUnidadMedida((UnidadMedida)cmbUnitMeasur.SelectedIndex);
                        Mostrar(pt3);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        FrmProducto frmProducto = new FrmProducto();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProducto = new FrmProducto(productoModel, 2);
            frmProducto.PModel = productoModel;
            frmProducto.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmProducto = new FrmProducto(productoModel,1);
            frmProducto.PModel = productoModel;
            frmProducto.ShowDialog();
        }
        private void vacio()
        {
            if (productoModel.productos == null)
            {
                throw new ArgumentException("Error,no ha ingresado productos");
            }
        }
        private void btnOrden_Click(object sender, EventArgs e)
        {
            try
            {
                vacio();
                productoModel.ordenar();
                Mostrar(productoModel.productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
