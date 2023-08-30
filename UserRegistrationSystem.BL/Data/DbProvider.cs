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


        public UserRegistrationSystemContext DbContext => _context;
        public bool IsEnabled { get; set; } = false;


        public void Save(T user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));


            if (user is User)
                _context.Users.Add(user as User);

            else if (user is Admin)
                _context.Admins.Add(user as Admin);


            if (IsEnabled)
                _context.SaveChanges();
        }

        public IEnumerable<T> Load()
        {
            return _context.Set<T>();
        }

        public T Find(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));


            return _context.Set<T>().SingleOrDefault
                (u => u.Name == name && u.Password == password);
        }

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

        public void Delete(T user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));


            _context.Set<T>().Remove(user);

            if (IsEnabled)
                _context.SaveChanges();
        }
    }
}