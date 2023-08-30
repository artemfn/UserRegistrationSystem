using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UserRegistrationSystem.BL.Model
{
    public class Admin : IUser
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string IdentificationKey { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}