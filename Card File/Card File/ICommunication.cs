using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_File
{
    /// <summary>
    /// @Author Daniel Cifka
    /// @Version 1.0
    /// Interface for general communication with a database or other storage space.
    /// General parameters that are specified in the implemented class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommunication<T>
    {
        /// <summary>
        /// Method for show all data in the storage space.
        /// </summary>
        /// <returns> List of all entities in storage space</returns>
        public List<T> Read();

        /// <summary>
        /// Method for show specificate data in the storage space.
        /// </summary>
        /// <param name="radiobutten">Name of column in the database table</param>
        /// <param name="data">Specification of entity</param>
        /// <returns> List of specific entities</returns>
        public List<T> Search(string radiobutten, string data);

        /// <summary>
        /// Method for delete entity from storage space.
        /// </summary>
        /// <param name="data">Specific entity</param>
        public void Delete(T data);

        /// <summary>
        /// Method for update information of specific entity
        /// </summary>
        /// <param name="data">Specific entity</param>
        /// <param name="newData">Updated specific entity</param>
        public void Update(T data, T newData);

        /// <summary>
        /// Method for add new entity into the storage space
        /// </summary>
        /// <param name="data">Specific entity</param>
        public void Add(T data);
    }
}
