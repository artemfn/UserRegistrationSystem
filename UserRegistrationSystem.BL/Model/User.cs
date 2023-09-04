using System.ComponentModel.DataAnnotations;

namespace UserRegistrationSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity User.
    /// </summary>
    public class User : IUser
    {
        /// <summary>
        /// Determines an id of entity in the table of database.
        /// </summary>
        [Key] public int Id { get; set; }
        /// <summary>
        /// Determines a name of user.
        /// </summary>
        [Required] public string Name { get; set; }
        /// <summary>
        /// Determines a password of user.
        /// </summary>
        [Required] public string Password { get; set; }
        /// <summary>
        /// Determines a email of user.
        /// </summary>
        [Required] public string Email { get; set; }
        /// <summary>
        /// Determines a phone number of user.
        /// </summary>
        [Required] public string PhoneNumber { get; set; }
        /// <summary>
        /// Determines a birth date of user.
        /// </summary>
        [Required] public string BirthDate { get; set; }
        

        public override string ToString()
        {
            return Name;
        }
    }
}