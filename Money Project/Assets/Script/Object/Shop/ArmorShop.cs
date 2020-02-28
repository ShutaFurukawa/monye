using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorShop : MonoBehaviour {

    //店メソッド
    private Shop script;

    // Use this for initialization
    void Start ()
    {
        script = this.GetComponent<Shop>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(script.Approach)
        {
            Debug.Log(this.gameObject.name + "に接近");
        }	
	}
}
