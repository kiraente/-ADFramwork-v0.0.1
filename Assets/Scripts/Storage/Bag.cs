using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;

namespace ADFramework.StorageCollections
{
    public class ADFWBag : ADFWStorage
    {
        protected ADFWItem[] _Items;
        public ADFWBag(string name, string desc, int size, GameObject owner ):base(name,desc,size,enumADFWStorageType.Bag,owner)
        {

        }
    }
}

