using UnityEngine;
using System.Collections;

namespace ADFramework.StorageCollections
{
    public abstract class ADFWBaseStorage : MonoBehaviour
    {

        //properties of a bag
        //and methods a bag can do

        protected string _StorageName;
        protected string _StorageDesc;
        protected enumADFWStorageType _StorageType;
        protected int _StorageSize;

        #region Properties
        public abstract string ADFWStorageName { get; set; }
        public abstract string ADFWStorageDescription { get; set; }
        public abstract enumADFWStorageType ADFWStorageType { get; set; }
        public abstract int ADFWStorageSize { get; set; }
        
        #endregion
    }

    public enum enumADFWStorageType
    {
        Account,
        Character,
        Bag,
        Chest,
        UnAssigned
    };

}

