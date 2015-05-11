using UnityEngine;
using System.Collections;
using System;


namespace ADFramework.ItemCollections.UseableItemCollections.Potions
{
    

    public class ADFWStarterHealthPotion:ADFWPotion
    {
        //starter information.
        //usage: remove the // and change the numbers at the end when you have a set your desired values
     
        //public int StarterBuyPrice=0;
        //public int StarterStackingQty=99;

        public ADFWStarterHealthPotion (int buyprice,int sellprice, int stacktotal):base("Starter Health Potion","Restore small amount of health", buyprice,sellprice,stacktotal )
        {
            
        }
        
    }

}


