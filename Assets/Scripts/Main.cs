using UnityEngine;
using System.Collections;
using ADFramework.ItemCollections;

public class Main : MonoBehaviour {
    //obj ref
    GameObject cube;
	void Awake()
    {
        //start by initialzing some stuff - this will be taken over by database connections etc.
        cube = GameObject.Find("Cube");

    }
	

}
