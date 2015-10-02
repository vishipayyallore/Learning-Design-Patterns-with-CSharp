using System.Collections.Generic;

namespace MongoData.IDataRepositories
{

    public interface IRepository<T> where T : IEntity
    {
        #region Methods
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
        #endregion
    }

}