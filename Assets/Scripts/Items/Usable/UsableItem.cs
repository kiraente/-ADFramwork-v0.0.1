using UnityEngine;
using System.Collections;
using ADFramework.IItemCollections;
using ADFramework.ItemCollections;
namespace ADFramework.ItemCollections.UsableItemCollections
{
    public abstract class UsableItem : Item, IItemUsable
    {
        protected int _Quantity;

        public abstract int Quantity { get; set; }
        public void ItemUse(){_Quantity--;}

    }

}

