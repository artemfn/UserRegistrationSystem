using System;
using System.Collections.Generic;
using System.Linq;
using UserRegistrationSystem.BL.Model;

namespace UserRegistrationSystem.BL.Data
{
    public class DbProvider<T>
        where T : class, IUser
    {
        private readonly UserRegistrationSystemContext _context = new UserRegistrationSystemContext();

        /// <summary>
        /// Determines the context of the database.
        /// </summary>
        public UserRegistrationSystemContext DbContext => _context;
        /// <summary>
        /// Defines that the changes will be saved to the database or not.
        /// </summary>
        public bool IsEnabled { get; set; } = false;

        /// <summary>
        /// Saves an object to the database.
        /// </summary>
        /// <param name="obj">A saving object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Save(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));


            if (obj is User)
                _context.Users.Add(obj as User);

            else if (obj is Admin)
                _context.Admins.Add(obj as Admin);


            if (IsEnabled)
                _context.SaveChanges();
        }

        /// <summary>
        /// Loads an object from the database of type <see cref="T"/>.
        /// </summary>
        /// <returns>Loaded object.</returns>
        public IEnumerable<T> Load()
        {
            return _context.Set<T>();
        }

        /// <summary>
        /// Finds a user in the database by a name and a password.
        /// </summary>
        /// <param name="name">A name of finding user.</param>
        /// <param name="password">A password of finding user.</param>
        /// <returns>Found user.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public T Find(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));


            return _context.Set<T>().SingleOrDefault
                (u => u.Name == name && u.Password == password);
        }

        /// <summary>
        /// Finds an admin  in the database by a name, a password and a identification key.
        /// </summary>
        /// <param name="name">A name of finding admin.</param>
        /// <param name="password">A password of finding admin.</param>
        /// <param name="key">An identification key of finding admin.</param>
        /// <returns>Found admin.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Admin Find(string name, string password, string key)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));


            return _context.Set<Admin>().SingleOrDefault
                (a => a.Name == name && a.Password == password && a.IdentificationKey == key);
        }

        /// <summary>
        /// Delete an object from the database.
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Delete(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));


            _context.Set<T>().Remove(obj);

            if (IsEnabled)
                _context.SaveChanges();
        }
    }
}