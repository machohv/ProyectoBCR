using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace ClientInterface
{
    public partial class Login : System.Web.UI.Page
    {
        private UserVerification verificator = new UserVerification();
        private EntidadAdministrator administrator = new EntidadAdministrator();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                Validate();
            } else
            {
                Session["user"] = null;
            }
        }

        public void CedulaValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (administrator.getEntidad(txtCedula.Text) != null);
        }

        public void PasswordValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (administrator.validateUser(txtCedula.Text, txtPassword.Text));
        }

        

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["user"] = administrator.getEntidad(txtCedula.Text);
                Response.Redirect("Home.aspx");
            }
        }
    }
}