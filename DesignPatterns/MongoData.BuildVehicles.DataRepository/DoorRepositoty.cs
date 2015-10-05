using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoData.DesignPattern.DataModels;
using MongoData.IDataRepositories;

namespace MongoData.BuildVehicles.DataRepository
{
    public class DoorRepositoty : IRepository<Door>
    {

        public DoorRepositoty()
        {
        }

        public IEnumerable<Door> List { get; }

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
    }
}
