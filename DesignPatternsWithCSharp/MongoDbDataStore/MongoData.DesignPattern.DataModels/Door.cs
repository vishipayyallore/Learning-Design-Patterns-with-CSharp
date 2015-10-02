using MongoData.DesignPattern.IDataModels;

namespace MongoData.DesignPattern.DataModels
{

    public class Door : IEntity
    {
        #region Properties
        public int NumberOfItems { get; set; }
        #endregion

        public string Id { get; set; }
        public string Name { get; set; }
    }

}
