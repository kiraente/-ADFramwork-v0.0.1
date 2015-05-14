using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using System.Collections.Generic;


[System.Serializable]
public class Item  {
    public int _Qty;
    public int _StackingQty;
    public int _SellingPrice;
    public int _BuyingPrice;

    public string _Name;
    public string _Desc;

    public Dictionary<enumADFWItemAttributes, bool> _ItemAttributes;
    public Dictionary<enumADFWItemType, bool> _ItemType;

}
