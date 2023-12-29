using Hospital.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(Hospital.Startup))]
namespace Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            PopulateUserAndRoles();
        }
        public void PopulateUserAndRoles()
        {
            var db = new ApplicationDbContext();

            if(!db.Roles.Any(x => x.Name == MyRoles.Admin))
            {
                db.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole(MyRoles.Admin));
                db.SaveChanges();
            }
            if(!db.Roles.Any(x => x.Name == MyRoles.Manager))
            {
                db.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole(MyRoles.Manager));
                db.SaveChanges();
            }
            if (!db.Roles.Any(x => x.Name == MyRoles.User))
            {
                db.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole(MyRoles.User));
                db.SaveChanges();
            }

            if(!db.Users.Any(x => x.UserName == "appadmin"))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var UserManager = new ApplicationUserManager(userStore);
                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = "appadmin@test.com",
                    UserName = "appadmin"
                };
                UserManager.Create(newUser, "applicationadmin");
                UserManager.AddToRole(newUser.Id, MyRoles.Admin);
                db.SaveChanges();
            }
            if (!db.Users.Any(x => x.UserName == "appmanager"))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var UserManager = new ApplicationUserManager(userStore);
                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = "appmanager@test.com",
                    UserName = "appmanager"
                };
                UserManager.Create(newUser, "applicationmanager");
                UserManager.AddToRole(newUser.Id, MyRoles.Manager);
                db.SaveChanges();
            }
            if (!db.Users.Any(x => x.UserName == "appuser"))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var UserManager = new ApplicationUserManager(userStore);
                var roleStore = new RoleStore<IdentityRole>(db);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var newUser = new ApplicationUser
                {
                    Email = "appuser@test.com",
                    UserName = "appuser"
                };
                UserManager.Create(newUser, "applicationuser");
                UserManager.AddToRole(newUser.Id, MyRoles.User);
                db.SaveChanges();
            }
        }
    }
}
