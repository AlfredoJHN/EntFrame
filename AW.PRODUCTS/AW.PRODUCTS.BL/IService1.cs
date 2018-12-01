using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AW.PRODUCTS.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract] //Clase
    public interface IAWProductos
    {
        [OperationContract]
        IList<MODEL.V2.ComboDeProductos> ListarIDYNombreProductos(string elColor);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        IList<MODEL.V2.Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior);

        [OperationContract]
        IList<MODEL.V2.Product> ListarProductosPorColor(string elColor);

        [OperationContract]
        IList<MODEL.V2.Product> ListarProductosPorNombreDeCategoria(string laCategoria);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract] //Tipo de datos compuestos referenciados dentro de la clase
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
