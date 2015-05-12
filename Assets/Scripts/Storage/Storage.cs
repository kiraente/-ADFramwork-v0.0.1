using UnityEngine;
using System.Collections;
using ADFramework.IStorageCollections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UseableItemCollections;
using ADFramework.ItemCollections.UseableItemCollections.Potions;
using System;

namespace ADFramework.StorageCollections
{
    
    public  class ADFWStorage :ADFWBaseStorage, IStorageItemStackable<ADFWItem>,IStorageItemSwitchable<ADFWItem>,IStorageItemTrashable<ADFWItem>
    {
        #region Members
        protected GameObject _Owner;
        protected Guid _ID;
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
        public Guid ID { get { return _ID; } }
        #endregion

        #region Constructors
        public ADFWStorage(string storagename,string storagedesc, int size,enumADFWStorageType storagetype, GameObject owner)
        {
            _StorageDesc = storagedesc;
            _StorageName = storagename;
            _StorageSize = size;
            _StorageType = storagetype;
            _Owner = owner;
            _ID = Guid.NewGuid();
        }
        #endregion

        #region Interface implementation
        public void ItemStack(ADFWItem obj, ADFWItem target) 
        {
            if (obj.Equals(target) && obj.ADFWItemAttributes.ContainsKey(enumADFWItemAttributes.CanBeStack))
            {
                obj.ADFWQuantity = obj.ADFWQuantity + target.ADFWQuantity - obj.ADFWStackingQty;                   
                if (obj.ADFWQuantity <= 0) 
                {
                    target.ADFWQuantity = obj.ADFWQuantity + target.ADFWQuantity;
                    Destroy(obj); 
                }
                else
                {
                    target.ADFWQuantity = target.ADFWStackingQty;                       
                }
             }
        }
        public void ItemSwitch(ADFWItem obj, ADFWItem target)
        { 
            //need to implement.
        }
        public void ItemTrash(ADFWItem obj)
        {
            if (obj.ADFWItemAttributes.ContainsKey(enumADFWItemAttributes.CanBeDestroy))
                Destroy(obj);
        }
        #endregion

    }
}