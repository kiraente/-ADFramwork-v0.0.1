using UnityEngine;
using System.Collections;
using System;

namespace ADFramework.ItemCollections.UseableItemCollections.Potions
{

    public class ADFWHealthPotion : ADFWUsableItem
    {
       
        #region Constructors
        
        public ADFWHealthPotion(string name, string desc,int sprice,int bprice,int stacktotal ):base()
        {
            _Name = name;
            _Desc = desc;
            _SellingPrice = sprice;
            _BuyingPrice = bprice;
            _StackingQty = stacktotal;
            _ItemAttributes.Add(enumADFWItemAttributes.CanBeStack, false);
 
        }
        

        #endregion

    }
}


