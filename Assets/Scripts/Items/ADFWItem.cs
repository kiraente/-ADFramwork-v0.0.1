using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


namespace ADFramework.ItemCollections
{
    public class ADFWItem : ADFWBaseItem,IEquatable<ADFWItem> /// this is a concreate of all items in the project
    {
        //abstract item properties, item is concrete and inherits monobehavior from baseiteme
        protected int _Qty;
        protected Guid _ID;
        protected int _StackingQty;
        protected int _SellingPrice;
        protected int _BuyingPrice;
        protected Dictionary<enumADFWItemAttributes, bool> _ItemAttributes;
        protected Dictionary<enumADFWItemType, bool> _ItemType;
        //must inherit based on the item created
        public Dictionary<enumADFWItemAttributes, bool> ADWAttributes
        {
            get { return _ItemAttributes; }
        }
        public Dictionary<enumADFWItemType, bool> ADFWItemType
        {
            get { return _ItemType; }
        }
        public int ADFWStackingQty { get { return _StackingQty; } }
        public int ADFWQuantity
        {
            get { return _Qty; }
            set { _Qty = value; }
        }
        public int ADFWSellingPrice { get { return _SellingPrice; } }
        public int ADFWBuyingPrice { get { return _BuyingPrice; } }
        public Guid ADFWID { get { return _ID; } }
        public override string ADFWName
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public override string ADFWDescription
        {
            get { return _Desc; }
            set { _Desc = value; }
        }
        public int ADFWAddToStack(ADFWItem target)
        {
            int tmp = _Qty + target.ADFWQuantity - _StackingQty;
            if (tmp >0)
            {
                target.ADFWQuantity = _StackingQty;
            }
            else
            {
                target.ADFWQuantity = tmp;
            }
            return tmp;
        }
        public Dictionary<enumADFWItemAttributes, bool> ADFWItemAttributes
        {
            get { return _ItemAttributes; }
        }
        
        public bool Equals(ADFWItem compare)
        {
            bool rtValue = false;
            if (this._ID==compare.ADFWID)
            {
                rtValue= true;
            }
            return rtValue;
        }///compares two item based on guid;

        #region constructor
        public ADFWItem()
        {
            _ID = Guid.NewGuid();
            _Qty = 0;
            _ItemType = new Dictionary<enumADFWItemType, bool>();
            _ItemAttributes = new Dictionary<enumADFWItemAttributes, bool>();
            _ItemAttributes.Add(enumADFWItemAttributes.CanBeDestroy, true);
        }
        #endregion
    }

    //Enumeration..

    public enum enumADFWItemType
    {
        Usable,
        Equipment,
        Pet,
        Misc
    }
    public enum enumADFWItemAttributes
    {
        MainQuestItem,
        QuestItem,
        CraftEndProduct,
        CraftMaterial,
        CanBeSold,
        CanBeBought,
        CanBeDestroy,
        CanBeEquip,
        CanBeUse,
        CanBeTrade,
        CanBeStack
    }

    //a potion= can be: a mainquest, a quest, main quest, an end product, a material, 
    //it can be sold, bough, destroy, use, trade and stack
    // but it cannot be equip.

    //an sword can be a main quest item, but cannot be equip, but can also be equip and not a main quest or both.
    //  
}

