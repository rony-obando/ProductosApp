using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime Vencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public int CompareTo(Producto other)
        {
            return new ProductoIdCompare().Compare(this, other);
        }

        public class ProductoIdCompare : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if (x.ID > y.ID)
                {
                    return 1;
                }
                else if (x.ID < y.ID)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class ProductoPrecioCompare : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if (x.Precio > y.Precio)
                {
                    return 1;
                }
                else if (x.Precio < y.Precio)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
