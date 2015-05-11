using UnityEngine;
using System.Collections;
using ADFramework.StorageCollections;
using ADFramework.IStorageCollections;

public class StoragePlayer : ADFWStorage, IStorageItemTrashable<GameObject>, IStorageItemMoveable<GameObject>, IStorageItemSwitchable<GameObject>, IStorageItemStackable<GameObject>, IStorageItemSplitable<GameObject>,IStorageItemReOrganizeable
{
    public void ItemTrash(GameObject obj) { 
        Destroy(obj); 
    }
    public void ItemStack(GameObject obj, GameObject replace) { 
        
    }
    public void ItemSplit(GameObject obj, int size) { }
    public void ItemMove(GameObject obj, int log) { }
    public void ItemSwitch(GameObject obj, GameObject replace) { }
    public void ItemReOrganize() { }



}
