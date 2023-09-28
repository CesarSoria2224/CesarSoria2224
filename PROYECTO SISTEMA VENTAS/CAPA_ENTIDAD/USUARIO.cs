using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD {
    public class USUARIO {
        public int IDUSUARIO { get; set; }
        public string DOCUMENTO { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public string CORREO { get; set; }
        public string CLAVE { get; set; }
        public ROL OROL { get; set; }
        public bool ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }

}
