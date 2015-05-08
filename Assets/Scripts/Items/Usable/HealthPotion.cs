using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections.UsableItemCollections;
using ADFramework.IItemCollections;

namespace ADFramework.ItemCollections.UsableItemCollections
{

    public class HealthPotion : UsableItem, IItemCraftable,IItemSellable 
    {
        protected int _StackingQty;
        protected int _SellingPrice;
        protected int _BuyingPrice;

        protected bool _IsTradeable;
        protected bool _IsSellable;
        protected bool _IsCraftable;

        #region Properties
        public override int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public bool IsTradeable
        {
            get { return _IsTradeable; }            
        }
        public bool IsSellable
        { 
            get { return _IsSellable; } 
        }
        public bool IsCraftable
        {
            get { return _IsCraftable; }
        }
        #endregion

        #region Interface implementation
        public int ItemSell(int qty)
        {
            return 0;
        }
        public void ItemCraft()
        {
        }
        #endregion
        
    }
}


