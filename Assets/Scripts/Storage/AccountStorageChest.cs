using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UseableItemCollections;

namespace ADFramework.StorageCollections
{
    public sealed class AccountStorageChest : ADFWStorage
    {
        private int _ActiveStorageSize;
        private ADFWItem[] _StoredItems;


        #region Constructor
        public AccountStorageChest(GameObject onwner)
        {
            _StorageName = "Account Shared Storage Chest";
            _StorageType = enumADFWStorageType.Account;
            _Owner = ADFWOwner;
            _StorageSize = 90;
            _ActiveStorageSize = 60;

        }
        #endregion

    }
}




