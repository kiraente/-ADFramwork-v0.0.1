using UnityEngine;
using System.Collections;
using System;
using ADFramework.IItemCollections;

namespace ADFramework.ItemCollections
{
    public class Item : BaseItem,IItemDestroyable

    {
        //abstract item properties, item is concrete and inherits monobehavior from baseiteme
        protected int _Qty;
        protected Guid _ID;
        public override string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public override string Description
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        #region constructor
        public Item()
        {
            _ID = Guid.NewGuid();
            _Qty = 0;
        }
        public Item(string name, string desc)
        {
            _ID = Guid.NewGuid();
            _Qty = 0;
            _Name = name;
            _Desc = desc;
        }
        public Item(string name, string desc,int qty)
        {
            _ID = Guid.NewGuid();
            _Qty = qty;
            _Name = name;
            _Desc = desc;
        }
        #endregion

        #region Interface Implementation
        public void Destroy()
        {
            UnityEngine.GameObject.Destroy(this.gameObject);
        }
        #endregion
    }
}

