using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.PRODUCTS.MODEL.V2
{
    public partial class Product
    {
        public string SizeInInches {
            get
            {   string Resultado = Size;
                if (SizeUnitMeasureCode != null &&
                      SizeUnitMeasureCode == "CM")
                {
                    float TamanoFloat = 0;
                    float.TryParse(Size, out TamanoFloat);
                    Resultado = (TamanoFloat / (float)2.54).ToString();
                }
                 return Resultado;
            }
            set { }
        }
    }
}