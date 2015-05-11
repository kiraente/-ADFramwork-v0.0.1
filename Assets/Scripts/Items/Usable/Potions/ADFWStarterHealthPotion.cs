using UnityEngine;
using System.Collections;
using System;


namespace ADFramework.ItemCollections.UseableItemCollections.Potions
{
    

    public class ADFWStarterHealthPotion:ADFWHealthPotion
    {
        //starter information.
        //usage: remove the // and change the numbers at the end when you have a set your desired values
     
        //public int StarterBuyPrice=0;
        //public int StarterStackingQty=99;

        public ADFWStarterHealthPotion ():base("Starter Health Potion","Restore small amount of health", 10, 10, 10 )
        {
            
        }
        
    }

}


