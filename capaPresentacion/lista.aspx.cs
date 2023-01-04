using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace capaPresentacion
{
    public partial class lista : System.Web.UI.Page
    {
        DataClasses1DataContext conexion = new DataClasses1DataContext();

        

        public void llenardgv()
        {
            GridView1.DataSource = llamadatos();
        }

        public List<sp_loadResult> llamadatos()
        {
            var llamada = conexion.sp_load();
            return llamada.ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = conexion.sp_load();
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}