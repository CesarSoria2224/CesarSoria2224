using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class COMPRA {
        public int IDCOMPRA { get; set; }
        public USUARIO OSUARIO { get; set; }
        public PROVEEDOR OPROVEEDOR { get; set; }
        public string TIPO_DOCUMENTO { set; get; }
        public string NRO_DOCUMENTO { set; get; }
        public decimal MONTO_TOTAL { set; get; }
        public List<DETALLE_COMPRA> ODETALLE_COMPRA { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }


}
