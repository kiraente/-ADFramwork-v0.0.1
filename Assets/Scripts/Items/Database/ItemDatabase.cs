using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ADFramework.ItemCollections;
public class ItemDatabase : MonoBehaviour {
    protected List<ADFWItem> _Items = new List<ADFWItem>();

    public ItemDatabase()
    {
            //create item
        _Items.AddRange(new ADFramework.ItemCollections.UseableItemCollections.Potions.ADFWStarterHealthPotion[] {
                new ADFramework.ItemCollections.UseableItemCollections.Potions.ADFWStarterHealthPotion(10,10,99),
                new ADFramework.ItemCollections.UseableItemCollections.Potions.ADFWStarterHealthPotion(20,20,99),
                new ADFramework.ItemCollections.UseableItemCollections.Potions.ADFWStarterHealthPotion(40,40,50)
        });
    }
    public ADFWItem ItemAt(int idx)
    {
        if (idx < _Items.Count && idx >= 0)
            return _Items[idx];
        else
            return null;
    }    

}
