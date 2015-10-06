using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MongoData.DesignPattern.IDataModels;

namespace MongoData.IDataRepositories
{

    public interface IRepository<T> where T : IEntity
    {
        #region Properties
        IEnumerable<T> List { get; }
        #endregion

        #region Methods
        Task<HttpStatusCode> Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<T> FindById(string id);
        #endregion
    }

}