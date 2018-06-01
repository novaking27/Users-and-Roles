using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Dapper;
using System.Data.SQLite;
using System.IO;


namespace UserDataService
{
    /// <summary>
    /// Summary description for UserDataService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserDataService : System.Web.Services.WebService
    {

        private SQLiteConnection GetConnection()
        {
            var create_file = Server.MapPath("~/app_data/create.sql");
            var create_query = File.ReadAllText(create_file);
            var db_file = Server.MapPath("~/App_Data/Users.db");
            var db = new SQLiteConnection($"Data Source={db_file}");
            if (File.Exists(db_file)== false)
            {
                db.Execute(create_query);
            }

            return db;
}
        [WebMethod]
       public bool ValidateUserCredentials(string username, string pass)
        {
            var db = GetConnection();
            var query = "SELECT COUNT (*) FROM users WHERE userName = @user AND password = @pass";
            var param = new { user = username, pass };
            var results = db.ExecuteScalar(query, param);
            return (long)results == 1;
        }

        [WebMethod]
        public string[] GetRolesForUser(string username)
        {
            var db = GetConnection();
            var query = "SELECT roleName FROM userRolesView WHERE userName = @un";
            var param = new { un = username };
            var results = db.Query<string>(query, param);
            return results.ToArray();
        }

        [WebMethod]
        public Role[] GetAllRoles()
        {
            var db = GetConnection();
            var query = "SELECT * FROM roles";
            return db.Query<Role>(query).ToArray();

        }
       [WebMethod]
       public void AddRoleToUser(string roleID, string userID)
        {
            var query = "INSERT INTO user_roles (user, role) VALUES (@user, @roles)";
            var param = new { user = userID, roles = roleID };
            var db = GetConnection();
            db.Execute(query, param);
        }
    }
}
