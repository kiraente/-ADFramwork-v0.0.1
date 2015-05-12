using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;

namespace ADFramework.StorageCollections
{
    public class StoragePlayer : ADFWStorage
    {
        protected ADFWItem[] _Items;
        public StoragePlayer(GameObject owner): base("Player Inventory", "Player's Inventory on character", 30, enumADFWStorageType.Character, owner)
        {
            _Items = new ADFWItem[30];

        }

    }

}
