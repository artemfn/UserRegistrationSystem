using System.Data.Entity;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.BL.Data
{
    /// <summary>
    /// Implements connection to (LocalDb)\MSSQLLocalDB.
    /// </summary>
    public class UserRegistrationSystemContext : DbContext
    {
        /// <summary>
        /// Implements connection settings.
        /// </summary>
        public UserRegistrationSystemContext() : base("UserRegistrationSystem")
        {
        }

        /// <summary>
        /// Set the database table which class <see cref="User"/> implements.
        /// </summary>
        public virtual DbSet<User> Users { get; set; }
        /// <summary>
        /// Set the database table which class <see cref="Admin"/> implements.
        /// </summary>
        public virtual DbSet<Admin> Admins { get; set; }
    }
}