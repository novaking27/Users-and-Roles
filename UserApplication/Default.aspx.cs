using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var svc = new UserDataServiceProxy.UserDataServiceSoapClient();
            var vaild = svc.ValidateUserCredentials(ctlLogin.UserName, ctlLogin.Password);

            if (vaild)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(ctlLogin.UserName, ctlLogin.RememberMeSet);

            }
            else
            {

            }

        }
    }
}