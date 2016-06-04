using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace UserInterface
{
    public partial class Login : System.Web.UI.Page
    {
        private UserVerification verificator = new UserVerification();
        private EmpleadosAdministrator administrator = new EmpleadosAdministrator();
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
            args.IsValid = (administrator.getEmpleado(txtCedula.Text) != null);
        }

        public void PasswordValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (verificator.verifyPassword(txtCedula.Text, txtPassword.Text));
        }

        

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Session["user"] = administrator.getEmpleado(txtCedula.Text);
                Response.Redirect("Home.aspx");
            }
        }
    }
}