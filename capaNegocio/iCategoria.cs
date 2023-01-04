using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaPresentacion;
using System.Configuration;

namespace capaNegocio
{
    public class iCategoria
    {
        Categoria atributo = new Categoria();
        Index cajas = new Index();

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoConnectionString"].ConnectionString);

        void test()
        {
            

            SqlCommand cmd = new SqlCommand("sp_create", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idcategoria", SqlDbType.VarChar).Value = atributo.idCategoria;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = atributo.descripcion;
            cmd.ExecuteNonQuery();
            con.Close();
            //PONER DETALLES DEL NUEVO REGISTRO Y MENSAJE DE EXITO
            
        }
            


    }
}
