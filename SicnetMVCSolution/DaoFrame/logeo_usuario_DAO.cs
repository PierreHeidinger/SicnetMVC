using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityFrame;
using System.Data.SqlClient;
using System.Data;

namespace DaoFrame
{
    public class logeo_usuario_DAO
    {
        conexion cn = new conexion();

        #region "LOGEO"
        public List<personal_Entity> identificacion(String a_USUARIO,String  a_PWD)
        {

            List<personal_Entity> lista = new List<personal_Entity>();
            cn.getcn.Open();
            SqlCommand cmd = new SqlCommand("SP_LOGIN_SESSION", cn.getcn);
            cmd.Parameters.Add(new SqlParameter("@USUARIO", a_USUARIO));
            cmd.Parameters.Add(new SqlParameter("@CONTRASENA", a_PWD));
            cmd.CommandType = CommandType.StoredProcedure;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var usuario = new personal_Entity();

                    usuario.cod_personal = (int)dr["COD_PERSONAL"];
                    usuario.nom_per = (string)dr["NOM_PER"];
                    usuario.ape_per = (string)dr["APE_P_PER"];
                    usuario.fecha_Registro = (DateTime)dr["FEC_REG"];
                    usuario.usuario = (string)dr["USUARIO"];
                    usuario.contrasena = (string)dr["CONTRASENA"];

                    lista.Add(usuario);
                }

            }
            cn.getcn.Close();
            return lista;
        }

        #endregion

    }
}
