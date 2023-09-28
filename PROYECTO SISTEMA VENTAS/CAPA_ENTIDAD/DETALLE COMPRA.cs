using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class DETALLE_COMPRA {
        public int IDDETALLECOMPRA { set; get; }
        public PRODUCTOS OPRODUCTOS { set; get; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public int CANTIDAD { set; get; }
        public decimal MONTO_TOTAL { set; get; }
        public string FECHA_REGISTRO { get; set; }
    }

}
