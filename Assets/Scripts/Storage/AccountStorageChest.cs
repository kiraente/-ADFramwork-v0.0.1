using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UseableItemCollections;

namespace ADFramework.StorageCollections
{
    public sealed class ADFWAccountStorageChest : ADFWStorage
    {
        private int _ActiveStorageSize;
        private ADFWItem[] _StoredItems;


        #region Constructor
        public ADFWAccountStorageChest(GameObject owner,int activesstoresize):base("Account storage","Account shared storage space",90,enumADFWStorageType.Account,owner)
        {
            _ActiveStorageSize = activesstoresize;
            _StoredItems = new ADFWItem[90];
            InitalizeStoreItems();
        }
        #endregion

        private void InitalizeStoreItems()
        {
            
        }

    }
}




