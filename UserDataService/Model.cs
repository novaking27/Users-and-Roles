using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserDataService
{
    public class User
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class Role
    {
        public long RoleID { get; set; }
        public string RoleName { get; set; }

    }

    public class UserRole
    {
        public long UserRoleID { get; set; }
        public long User { get; set; }
        public long Role { get; set; }
    }
}