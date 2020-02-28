using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    //アニメーションのフレーム数取得用
    private float flame;

    //アニメーション待機用変数
    private float waitAnim;
    //入力判定用変数
    private float inputFlame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //セットした攻撃を行う(3段階までセット可)
		//if(Input.GetButtonDown("Attack"))
  //      {
  //          //Debug.Log("FastAttack");
  //      }

        //アクションを行うフラグを立てる
        //if(Input.GetButtonDown("Action"))
        //{
        //    //Debug.Log("Action");
        //}

        //防御を行う
        //if(Input.GetButtonDown("Guard"))
        //{
        //    //Debug.Log("Guard");
        //}

    }
}
