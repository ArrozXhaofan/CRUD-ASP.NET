using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaEntidad;

namespace capaPresentacion
{
    public partial class Index : System.Web.UI.Page
    {
        Categoria atributo = new Categoria();
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["neptunoConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            mandarCajas();
            agregar();

            

        }

        void mandarCajas()
        {
            atributo.idCategoria = int.Parse(txtId.Text);
            atributo.nombreCategoria = txtNombre.Text;
            atributo.descripcion = txtDescripcion.Text;

            
        }
        void agregar()
        {


            SqlCommand cmd = new SqlCommand("sp_create", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = atributo.idCategoria;
            cmd.Parameters.Add("@nombrecategoria", SqlDbType.VarChar).Value = atributo.nombreCategoria;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = atributo.descripcion;
            cmd.ExecuteNonQuery();
            con.Close();
            //PONER DETALLES DEL NUEVO REGISTRO Y MENSAJE DE EXITO
        }

        void modificar()
        {
            SqlCommand cmd = new SqlCommand("sp_update", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = atributo.idCategoria;
            cmd.Parameters.Add("@nombrecategoria", SqlDbType.VarChar).Value = atributo.nombreCategoria;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = atributo.descripcion;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void eliminar()
        {
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = atributo.idCategoria;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            mandarCajas();
            modificar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            mandarCajas();
            eliminar();
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("lista.aspx");
        }
    }
}