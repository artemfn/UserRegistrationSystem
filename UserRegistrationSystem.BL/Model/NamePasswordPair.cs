namespace UserRegistrationSystem.BL.Model
{
    /// <summary>
    /// Determines a type that contains a name and a password properties.
    /// It can be used for designation of basic user data.
    /// </summary>
    public struct NamePasswordPair
    {
        /// <summary>
        /// Determines a name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Determines a password.
        /// </summary>
        public string Password { get; set; }
    }
}