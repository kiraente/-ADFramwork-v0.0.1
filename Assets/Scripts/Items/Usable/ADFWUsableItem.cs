using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
namespace ADFramework.ItemCollections.UseableItemCollections
{
    public class ADFWUsableItem : ADFWItem
    {
        public  int ADFWQuantity 
        { 
            get{return _Qty;}
            set { _Qty = value; }
        }
        public void ADFWUseItem()
        {
            _Qty--;            
        }
        public int ADFWAddToStack(int qty)
        {
            return 0; 
            
        }
        public ADFWUsableItem(): base()
        {
            _ItemType.Add(enumADFWItemType.Usable, true);
            _ItemAttributes.Add(enumADFWItemAttributes.CanBeUse, true);
                        
        }


    }

}

