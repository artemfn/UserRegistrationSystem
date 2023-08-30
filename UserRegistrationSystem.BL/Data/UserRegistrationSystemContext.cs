using System.Data.Entity;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.BL.Data
{
    public class UserRegistrationSystemContext : DbContext
    {
        public UserRegistrationSystemContext() : base("UserRegistrationSystem")
        {
        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
    }
}