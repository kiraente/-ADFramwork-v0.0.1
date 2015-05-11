using UnityEngine;
using System.Collections;
using ADFramework.IStorageCollections;
using ADFramework.ItemCollections;
using System;

namespace ADFramework.StorageCollections
{
    
    public  class ADFWStorage :ADFWBaseStorage, IStorageItemStackable<ADFWItem>,IStorageItemSwitchable<ADFWItem>,IStorageItemTrashable<ADFWItem>
    {
        #region Members
        protected GameObject _Owner;
        #endregion

        #region Properties
        public override string ADFWStorageName
        {
            get { return _StorageName; }
            set { _StorageName = value; }
        }
        public override string ADFWStorageDescription
        {
            get { return _StorageDesc; }
            set { _StorageDesc = value; }
        }
        public override enumADFWStorageType ADFWStorageType
        {
            get { return _StorageType; }
            set { _StorageType = value; }
        }
        public override int ADFWStorageSize
        {
            get { return _StorageSize; }
            set { _StorageSize = value; }
        }
        public GameObject ADFWOwner
        {
            get { return _Owner; }
        }
        #endregion

        #region Constructors
        public ADFWStorage() { }
        public ADFWStorage(string storagedesc,string storagename, int size,enumADFWStorageType storagetype, GameObject owner)
        {
            _StorageDesc = "";
            _StorageName = "";
            _StorageSize = 0;
            _StorageType = storagetype;
            _Owner = owner;
        }
        #endregion

        #region Interface implementation
        public void ItemStack(ADFWItem obj, ADFWItem target) 
        {
            if (obj.ADFWItemAttributes.ContainsKey(enumADFWItemAttributes.CanBeStack))
            { 
                //check if type is usable or misc and cast object to that 
                
                if (obj.ADFWItemType.ContainsKey(enumADFWItemType.Usable))
                { 
                    if (obj.Equals(target))
                    {
                        //useable item, and they are both the same
                        //get the total allow
                    
                    }

                }
                if (obj.ADFWItemType.ContainsKey(enumADFWItemType.Misc))
                { 
                }


            }
        }
        public void ItemSwitch(ADFWItem obj, ADFWItem target)
        { }
        public void ItemTrash(ADFWItem obj)
        { }
        #endregion

    }
}