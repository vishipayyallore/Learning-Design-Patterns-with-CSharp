using System.Collections.Generic;
using MongoData.DesignPattern.IDataModels;

namespace MongoData.IDataRepositories
{

    public interface IRepository<T> where T : IEntity
    {
        #region Properties
        IEnumerable<T> List { get; }
        #endregion

        #region Methods
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
        #endregion
    }

}