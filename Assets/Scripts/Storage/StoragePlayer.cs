using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;

namespace ADFramework.StorageCollections
{
    public sealed class StoragePlayer : ADFWStorage
    {
        private  ADFWItem[] _PCInventory; //player character inventory list
        private ItemDatabase _ItemDB;
        private bool _IsReady = false;
        public StoragePlayer(GameObject owner): base("Player Inventory", "Player's Inventory on character", 30, enumADFWStorageType.Character, owner)
        {
        }

        void Awake()
        {
            _PCInventory = new ADFWItem[30]; //30 slot base 0
            _ItemDB = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
            _PCInventory[0] = _ItemDB.ItemAt(0);
            _PCInventory[1] = _ItemDB.ItemAt(1);
            _IsReady = true;
            Debug.Log("2 inventory file.");
            
        }
        
        void OnGUI()
        {
            if( _IsReady)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (_PCInventory[i] != null)
                        GUI.Label(new Rect(10, i * 20, 200, 50), _PCInventory[i].ADFWName);
                    else
                        GUI.Label(new Rect(10, i * 20, 200, 50), "empty");
                }
            }
            
        }

    }

}
