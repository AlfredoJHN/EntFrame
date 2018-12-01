using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AW.PRODUCTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var elAccesoAlBusinessLogic = new AccesoBL.Productos();
            var listaDeProductos = elAccesoAlBusinessLogic.ListarProductosPorColor(cbColores.Text);
            CargarComboBoxConListaDeProductos(listaDeProductos);
        }


        private void CargarComboBoxConListaDeProductos
            (IList<MODEL.V2.ComboDeProductos> Lista)
        {
            cbProductos.Items.Clear();
            foreach(var item in Lista)
            {
                cbProductos.Items.Add(item.NombreProducto);
            }
        }
    }
}
