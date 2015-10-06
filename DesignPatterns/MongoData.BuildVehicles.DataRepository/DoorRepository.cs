using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using MongoData.BuildVehicles.DataStore;
using MongoData.DesignPattern.DataModels;
using MongoData.IDataRepositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoData.BuildVehicles.DataRepository
{
    public class DoorRepository : IRepository<Door>
    {

        private readonly BuildVehiclesContext _buildVehiclesContext;

        public DoorRepository()
        {
            _buildVehiclesContext = new BuildVehiclesContext();
        }

        #region Properties
        public IEnumerable<Door> List { get; }
        #endregion

        #region Properties
        public async Task<HttpStatusCode> Add(Door entity)
        {
            await _buildVehiclesContext.Doors.InsertOneAsync(entity);
            return HttpStatusCode.Accepted;
        }

        public void Delete(Door entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Door entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Door> FindById(string id)
        {
            return await _buildVehiclesContext.Doors.Find<Door>(d => d.Id == id).FirstOrDefaultAsync();
        }
        #endregion
    }
}