using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace UserRegistrationSystem.BL.Data
{
    /// <summary>
    /// Implements protected connection to json files.
    /// </summary>
    /// <typeparam name="T">A type of serializing data.</typeparam>
    public class JsonSerializationProvider<T>
        where T : class
    {
        private readonly DataContractJsonSerializer _serializer = new DataContractJsonSerializer(typeof(T));

        /// <summary>
        /// Saves data to the json file.
        /// If file is not exists, creates and saves.
        /// </summary>
        /// <param name="obj">A serializing data.</param>
        /// <param name="path">A path to the file.</param>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Loads data from the json file.
        /// </summary>
        /// <param name="path">a path to the file.</param>
        /// <returns>Loaded data.</returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Deletes the file.
        /// </summary>
        /// <param name="path">A path to the file.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
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