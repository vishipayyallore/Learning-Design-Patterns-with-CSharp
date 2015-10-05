using System.Collections.Generic;
using MongoData.DesignPattern.DataModels;
using MongoData.IDataRepositories;

namespace MongoData.BuildVehicles.DataRepository
{
    public class DoorRepository : IRepository<Door>
    {

        public DoorRepository() {  }

        #region Properties
        public IEnumerable<Door> List { get; }
        #endregion

        #region Properties
        public void Add(Door entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Door entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Door entity)
        {
            throw new System.NotImplementedException();
        }

        public Door FindById(int id)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}