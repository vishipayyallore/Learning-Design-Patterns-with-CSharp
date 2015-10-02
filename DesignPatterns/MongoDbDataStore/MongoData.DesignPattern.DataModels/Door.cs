using MongoData.DesignPattern.IDataModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoData.DesignPattern.DataModels
{

    public class Door : IEntity
    {
        #region Properties
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfItems { get; set; }
        #endregion

        public Door() { }

    }

}
