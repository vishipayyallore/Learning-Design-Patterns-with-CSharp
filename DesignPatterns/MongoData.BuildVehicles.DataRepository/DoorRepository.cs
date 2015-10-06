using System;
using System.Collections.Generic;
using MongoData.DesignPattern.DataModels;
using MongoData.IDataRepositories;

namespace MongoData.BuildVehicles.DataRepository
{
    public class DoorRepository : IRepository<Door>
    {
        #region Properties
        public IEnumerable<Door> List { get; }
        #endregion

        #region Properties
        public void Add(Door entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Door entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Door entity)
        {
            throw new NotImplementedException();
        }

        public Door FindById(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}