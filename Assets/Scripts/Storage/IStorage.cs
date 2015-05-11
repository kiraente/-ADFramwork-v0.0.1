using UnityEngine;
using System.Collections;

namespace ADFramework.IStorageCollections
{
    public interface IStorageItemStackable<T>{
        void ItemStack(T obj, T target);
    }

    public interface IStorageItemSplitable<T>{
        void ItemSplit(T obj, int size);
    }

    public interface IStorageItemTrashable<T>{
        void ItemTrash(T obj);
    }
    public interface IStorageItemMoveable<T>{
        void ItemMove(T obj, int loc);
    }
    public interface IStorageItemSwitchable<T>{
        void ItemSwitch(T obj, T replace);
    }
    public interface IStorageItemReOrganizeable{
        void ItemReOrganize();
    }
    public interface IStorageItemOwnerBoundable<T>{
        void BoundOwner(T owner);
        void UnboundOwner(T owner);
    //bind/unblind to owner    
    }
    
}