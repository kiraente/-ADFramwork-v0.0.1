using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
namespace ADFramework.ItemCollections.UseableItemCollections
{
    public class ADFWUsableItem : ADFWItem
    {
        public void ADFWUseItem()
        {
            _Qty--;            
        }

        public ADFWUsableItem(): base()
        {
            _ItemType.Add(enumADFWItemType.Usable, true);
            _ItemAttributes.Add(enumADFWItemAttributes.CanBeUse, true);
                        
        }


    }

}

