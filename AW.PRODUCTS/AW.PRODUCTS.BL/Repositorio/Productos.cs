using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.PRODUCTS.BL.Repositorio
{
    internal class Productos
    {
        private MODEL.V2.AdventureWorks2016Entities _contexto =
            new MODEL.V2.AdventureWorks2016Entities();

        public IList<MODEL.V2.Product> ListarProductosPorColor(string
            elColor)
        {
            var elResultado = _contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }

        public IList<MODEL.V2.ComboDeProductos> ListarIDYNombreProductos(string elColor)
        {
            var listaProductos = _contexto.Product.Where(p =>
            p.Color.Contains(elColor));

            IList<MODEL.V2.ComboDeProductos> elResultado =
                listaProductos.Select(p => 
                new MODEL.V2.ComboDeProductos {  idProducto = p.ProductID,
                                                 NombreProducto = p.Name}).ToList();
            return elResultado;
        }

    }
}