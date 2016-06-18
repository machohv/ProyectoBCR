using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace ClientInterface
{
    public partial class Home : System.Web.UI.Page
    {
        private Entidad entidad;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                entidad = (Entidad)Session["user"];
                HiddenCedula.Value = entidad.Cedula;
            }
        }
    }
}