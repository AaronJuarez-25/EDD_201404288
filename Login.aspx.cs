using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteEDD
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void Button1_Click(object sender, EventArgs e)
        {

            ServiceReference2.WebServicesSoapClient servicio = new ServiceReference2.WebServicesSoapClient();
            bool correcto = servicio.log(Nombre.Text,Pass.Text);

            if (correcto == true)
            {
                string display = "Acceso Permitido Administrador";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                Server.Transfer("Admin.aspx",true);
            }
            else {
                string display = "Error en el Usuario o Contrasena";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }
    }
}