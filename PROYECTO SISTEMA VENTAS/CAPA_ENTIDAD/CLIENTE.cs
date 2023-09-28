using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class CLIENTE {
        public int IDCLIENTE { set; get; }
        public string DOCUMENTO { set; get; }
        public string NOMBRE_COMPLETO { set; get; }
        public string CORREO { get; set; }
        public string TELEFONO { get; set; }
        public bool ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }

    }
}
