using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SAP_GCL.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SAP_GCL.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Material> Materials { get; set; }
        public DbSet<SAP_GCL.Models.GoodRecieptNote> GoodRecieptNotes { get; set; }

        public DbSet<SAP_GCL.Models.OutboundDeliveries> OutboundDeliveries { get; set; }
        public DbSet<SAP_GCL.Models.GoodMovement> GoodMovement { get; set; }
        public DbSet<SAP_GCL.Models.DocumentErrors> DocumentErrors { get; set; }
        public DbSet<SAP_GCL.Models.DataManager> DataManager { get; set; }
    }
}