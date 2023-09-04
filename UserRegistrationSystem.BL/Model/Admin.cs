using System.ComponentModel.DataAnnotations;

namespace UserRegistrationSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Admin.
    /// </summary>
    public class Admin : IUser
    {
        /// <summary>
        /// Determines an id of entity in the table of database.
        /// </summary>
        [Key] public int Id { get; set; }
        /// <summary>
        /// Determines a name of admin.
        /// </summary>
        [Required] public string Name { get; set; }
        /// <summary>
        /// Determines a password of admin.
        /// </summary>
        [Required] public string Password { get; set; }
        /// <summary>
        /// Determines a identification key of admin.
        /// </summary>
        [Required] public string IdentificationKey { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}