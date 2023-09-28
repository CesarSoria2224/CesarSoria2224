using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class DETALLE_VENTA {
        public int IDDETALLE_VENTA { get; set; }
        public PRODUCTOS OPRODUCTOS { set; get; }
        public decimal PRECIO_VENTA { get; set; }
        public int CANTIDAD { set; get; }
        public decimal SUB_TOTAL { set; get; }
        public string FECHA_REGISTRO { get; set; }
    }

}
