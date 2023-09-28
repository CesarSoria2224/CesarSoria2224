using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;



namespace CAPA_DATOS {
    public class CD_USUARIO 
    {
        public List<USUARIO> listar()
        {
            List<USUARIO> lista= new List<USUARIO>();
            using (SqlConnection oconexion = new SqlConnection(CONEXION.cadena))
            {
                try
                {
                    string query = "select IDUSUARIO,DOCUMENTO,NOMBRECOMPLETO,CORREO, CLAVE,ESTADO from USUARIO";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new USUARIO()
                            {
                                IDUSUARIO = Convert.ToInt32(dr["IDUSUARIO"]),
                                DOCUMENTO = dr["DOCUMENTO"].ToString(),
                                NOMBRE_COMPLETO = dr["NOMBRECOMPLETO"].ToString(),
                                CORREO = dr["CORREO"].ToString(),
                                CLAVE = dr["CLAVE"].ToString(),
                                ESTADO = Convert.ToBoolean(dr["ESTADO"])
                            }); 

                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<USUARIO>();
                }
            }
            return lista;

        }
    }
}
