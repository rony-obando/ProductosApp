using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Newtonsoft.Json;

namespace Infrastructure.Productos
{
    public class ProductoModel
    {
        [JsonProperty]
        public Producto[] productos;
        #region CRUD
        public void Add(Producto P)
        {
            Add(P, ref productos);
        }
        
        public Producto[] GetAll()
        {
            return productos;
        }
        public int Update(Producto P)
        {
            int index = GetIndexById(P);
            if (index < 0)
            {
                throw new Exception($"El producto con Id{P.ID} no se encontro");
            }
            productos[index] = P;

            return index;
        }
        private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[0] = p;
                return;
            }
            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        public bool Delete(Producto P)
        {
            int index = GetIndexById(P);

            if (index < 0)
            {
                throw new Exception($"El producto con ID: {P.ID} no se encontro");
            }
            if (index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;
            return productos.Length == tmp.Length;
        }
        public int GetIndexById(Producto P)
        {
            if (P == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }
            int index = int.MinValue;

            if (productos == null)
            {
                return index;
            }
            int i = 0;
            foreach (Producto pd in productos)
            {
                if (pd.ID == P.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        public Producto GetProductoById(int id)
        {
            
            Array.Sort(productos, new Producto.ProductoIdCompare());
            Producto p = new Producto { ID = id };
            int index = Array.BinarySearch(productos, p, new Producto.ProductoIdCompare());
            return index < 0 ? null : productos[index];
        }
        public Producto[] DeleteBy(Producto P)
        {
            int index = GetIndexById(P);
            Producto[] tmp = new Producto[productos.Length - 1];
            int j = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                tmp[j] = productos[i];
                if (j == tmp.Length - 1)
                {
                    break;
                }
                if (i == index)
                {
                    tmp[j] = productos[i + 1];
                    i++;
                }
                j++;
            }
            productos = new Producto[tmp.Length];
            productos = tmp;
            return productos;

        }
        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;
            foreach (Producto P in productos)
            {
                if (P.UnidadMedida == um)
                {
                    Add(P, ref tmp);
                }
            }
            return tmp;
        }
        public Producto[] GetProductosByCaducidad(DateTime dt)
        {
            Producto[] caducidad = null;
            if (productos == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }
            foreach (Producto P in productos)
            {
                if (P.Vencimiento.CompareTo(dt)<=0)
                {
                    Add(P, ref caducidad);

                }
            }
            if (caducidad == null)
            {
                throw new ArgumentException("No se encontró ningun producto que coincida");
            }
            return caducidad;
        }
        public Producto[] GetProductosByRangoPrecio(decimal start, decimal end)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            
            foreach (Producto P in productos)
            {
                if (start  <= P.Precio && end >= P.Precio)
                {
                    Add(P, ref tmp);
                }
            }
            return tmp;
        }
        
        public string GetProductosAsJson()
        {
            string a = "";
            if (productos == null)
            {
                return a;
            }
            return JsonConvert.SerializeObject(productos);
        }
        public Producto[] ordenar()
        {
            Array.Sort(productos, new Producto.ProductoPrecioCompare());
            return productos;
        }
        public int GetLastProductoId()
        {
            return productos == null ? 0 : productos[productos.Length - 1].ID;
        }
        #endregion
    }
}
