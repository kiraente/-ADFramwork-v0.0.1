using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UsableItemCollections;

namespace ADFramework.StorageCollections
{
    public sealed class AccountStorageChest : Storage
    {
        private int _ActiveStorageSize;
        private Item[] _StoredItems;

        #region Properties
        public override string StorageName
        {
            get { return _StorageName; }
            set { _StorageName = value; }
        }
        public override string StorageDescription
        {
            get { return _StorageDesc; }
            set { _StorageDesc = value; }
        }
        public override string StorageType
        {
            get { return _StorageType; }
            set { _StorageType = value; }
        }
        public override int StorageSize
        {
            get { return _StorageSize; }
            set { _StorageSize = value; }
        }
        public override GameObject Owner
        {
            get { return _Owner; }
        }
        #endregion

        #region Constructor
        public AccountStorageChest(GameObject onwner)
        {
            _StorageName = "Account Shared Storage Chest";
            _StorageType = "Account";
            _Owner = Owner;
            _StorageSize = 90;
            _ActiveStorageSize = 60;

        }
        #endregion

    }
}




