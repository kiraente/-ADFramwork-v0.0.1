using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UseableItemCollections.Potions;

public class Main : MonoBehaviour {
    //obj ref
    GameObject cube;
	void Awake()
    {
        //start by initialzing some stuff - this will be taken over by database connections etc.
        cube = GameObject.Find("HealthPotion");
        //test class

        
        this.gameObject.AddComponent<ADFWStarterHealthPotion>();
        ADFWStarterHealthPotion shp = this.gameObject.GetComponent<ADFWStarterHealthPotion>();
        Debug.Log(shp.ADFWName);
        Debug.Log(shp.ADFWDescription);
        Debug.Log("Is item usable type?" + shp.ADFWItemType.ContainsKey(enumADFWItemType.Usable));
        Debug.Log("Can Item be use: " + shp.ADFWItemAttributes.ContainsKey(enumADFWItemAttributes.CanBeUse));
        Debug.Log("Selling Price" + shp.ADFWSellingPrice);
        Debug.Log("Buying Price" +shp.ADFWBuyingPrice);
        Debug.Log("Current stacking quantity: " + shp.ADFWStackingQty);
        shp.ADFWQuantity = 100;
        Debug.Log("Current QTY on hand: " + shp.ADFWQuantity);
        shp.ADFWUseItem();
        Debug.Log("Used one quantity:" + shp.ADFWQuantity);
        Debug.Log("Checking if Item can be destroy");
        if (shp.ADFWItemAttributes.ContainsKey(enumADFWItemAttributes.CanBeDestroy))
        {
            Destroy(shp.gameObject);
            Debug.Log("The Game object HealthPotion have been destroyed successfully");
        }
        
        //Debug.Log(shp.)
                       
    }
	

}
