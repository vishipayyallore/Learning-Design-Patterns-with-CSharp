﻿namespace MongoData.DesignPattern.IDataModels
{

    public interface IEntity
    {
        #region Properties
        string Id { get; set; }

        string Name { get; set; }
        #endregion
    }

}