using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsShop : MonoBehaviour {

    private GoShopScript GSScript;

	// Use this for initialization
	void Start ()
    {
        GSScript = this.GetComponent<GoShopScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //if(GSScript.GetInShop)
     //   {
     //       Debug.Log(this.gameObject.name + "に入った！！");
     //   }	
	}
}
