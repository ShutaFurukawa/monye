using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnima : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxisRaw("ControlHor") != 0 || Input.GetAxisRaw("ControlVer") != 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
