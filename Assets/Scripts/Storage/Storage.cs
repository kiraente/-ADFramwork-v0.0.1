using UnityEngine;
using System.Collections;

namespace ADFramework.StorageCollections
{
    public abstract class Storage : MonoBehaviour
    {
        //properties of a bag
        //and methods a bag can do

        protected string _StorageName;
        protected string _StorageDesc;
        protected string _StorageType;
        protected int _StorageSize;
        protected GameObject _Owner;

        #region Properties
        public abstract string StorageName { get; set; }
        public abstract string StorageDescription { get; set; }
        public abstract string StorageType { get; set; }
        public abstract int StorageSize { get; set; }
        public abstract GameObject Owner { get; }


        #endregion
    }
}