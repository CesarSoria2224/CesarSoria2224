using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class PRODUCTOS {
        public int IDPRODUCTOS { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public CATEGORIA OCATEGORIA { get; set; }
        public int STOCK { get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public bool ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }

}
