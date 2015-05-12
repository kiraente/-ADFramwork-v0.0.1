using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;
using ADFramework.ItemCollections.UseableItemCollections.Potions;

public class Main : MonoBehaviour {
    //obj ref
    GameObject PCStorage;
	void Awake()
    {
        //start by initialzing some stuff - this will be taken over by database connections etc.

        //get bag
        PCStorage = GameObject.FindGameObjectWithTag("PCStorage");
        // fill all 30 slots?

        GameObject obj = new GameObject("Starter Health Potion");
        



                       
    }
	

}
