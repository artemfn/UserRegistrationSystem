using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace UserRegistrationSystem.BL.Data
{
    public class SerializationProvider<T>
        where T : class
    {
        private readonly DataContractJsonSerializer _serializer = new DataContractJsonSerializer(typeof(T));


        public void Save(T obj, string path)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));


            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                _serializer.WriteObject(fs, obj);
            }
        }

        public T Load(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));


            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    return _serializer.ReadObject(fs) as T;
                }
                catch (SerializationException)
                {
                    return default;
                }
            }
        }

        public void Delete(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                throw new InvalidOperationException(nameof(path));
            }
        }
    }
}