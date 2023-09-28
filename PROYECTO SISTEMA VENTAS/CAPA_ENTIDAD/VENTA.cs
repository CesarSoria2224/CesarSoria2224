using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class VENTA {
        public int IDVENTA { set; get; }
        public USUARIO OSUARIO { get; set; }
        public string TIPO_DOCUMENTO { set; get; }
        public string DOCUMENTO_CLIENTE { set; get; }
        public decimal MONTO_PAGO { set; get; }
        public decimal MONTO_CAMBIO { set; get; }
        public decimal MONTO_TOTAL { set; get; }
        public List<DETALLE_VENTA> ODETALLE_VENTA { set; get; }
        public string FECHA_REGISTRO { get; set; }
    }

}
