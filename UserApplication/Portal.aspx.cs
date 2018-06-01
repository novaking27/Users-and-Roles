using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserApplication
{
    public partial class Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svc = new UserDataServiceProxy.UserDataServiceSoapClient();
            var roles = svc.GetRolesForUser(User.Identity.Name);
            gvRoles.DataSource = roles;
            gvRoles.DataBind();


            if (IsPostBack) return;
            ddlRoles.DataSource = svc.GetAllRoles();
            ddlRoles.DataTextField = "RoleName";
            ddlRoles.DataValueField = "RoleID";
            ddlRoles.DataBind();
            
        }

        protected void btnAddroles_Click(object sender, EventArgs e)
        {
            if (User.IsInRole("developer")|| User.IsInRole("Management"))
            {
                var svc = new UserDataServiceProxy.UserDataServiceSoapClient();
                var userID = txtUserID.Text;
                var roleId = ddlRoles.SelectedValue;
                svc.AddRoleToUser(roleId, userID);
            }
        }
    }
}