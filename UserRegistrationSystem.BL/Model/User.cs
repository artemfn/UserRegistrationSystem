using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UserRegistrationSystem.BL.Model
{
    public class User : IUser
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required] public string BirthDate { get; set; }
        

        public override string ToString()
        {
            return Name;
        }
    }
}