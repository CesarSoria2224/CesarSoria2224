using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO {
    public class CN_USUARIO {

        private CD_USUARIO objcd_USUARIO = new CD_USUARIO();

        public List<USUARIO> listar()
        {
            return objcd_USUARIO.listar();
        }
    }
}
