using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.PRODUCTS.AccesoBL
{
    public class Productos
    {
        public IList<MODEL.V2.Product> ListarProductosPorColor(string elColor)
        {
            var elClienteWcf = new SI.WcfProductos.AWProductosClient();

            var elResultado = elClienteWcf.ListarProductosPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
        }
    }
}
