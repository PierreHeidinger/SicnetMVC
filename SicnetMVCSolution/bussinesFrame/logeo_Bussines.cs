using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityFrame;
using DaoFrame;


namespace bussinesFrame
{
    public class logeo_Bussines
    {


        public List<personal_Entity> tb_clientes(String USUARIO,String CONTRASENA)
        {
            var cliente = new logeo_usuario_DAO();
            return cliente.identificacion(USUARIO,CONTRASENA);

        }







    }

}
