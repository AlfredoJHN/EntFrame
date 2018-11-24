using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.PRODUCTS.BL.Repositorio
{
    internal class Productos
    {
        private MODEL.AdventureWorks2016Entities _contexto =
            new MODEL.AdventureWorks2016Entities();

        public IList<MODEL.Product> ListarProductosPorColor(string
            elColor)
        {
            var elResultado = _contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }
    }
}