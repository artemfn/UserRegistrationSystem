namespace UserRegistrationSystem.BL.Model
{
    /// <summary>
    /// Determines an universal tool for working with different types of user. 
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Determines a name of user.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Determines a password of user.
        /// </summary>
        string Password { get; set; }
    }
}