using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoShopScript : MonoBehaviour {


    //private GameObject instaImg = null;        //格納用オブジェクト

    //private bool viewImg = false;
    //private bool toShop = false;

    ////店の入口に近づいたとき
    //void OnTriggerEnter(Collider other)
    //{
    //    viewImg = true;
    //}

    ////店から離れたとき
    //void OnTriggerExit(Collider other)
    //{
    //    if (instaImg != null)
    //    {
    //        //オブジェクトの破棄
    //        Destroy(instaImg.gameObject);
    //    }
    //}

    //void Update()
    //{
    //    ViewInShop();
    //    //アクションボタンを押す
    //    if (Input.GetButtonDown("Button1"))
    //    {
    //        //店の入り口付近に居るなら
    //        if (viewImg)
    //        { 
    //            //入店フラグ立てる
    //            toShop = true;
    //        }
    //    }
    //}

    ////入店UI表示
    //private void ViewInShop()
    //{
    //    //何かしらの店に近づいているなら
    //    if (viewImg)
    //    {
    //        ////UIの生成
    //        //instaImg = Instantiate(Resources.Load<GameObject>("Prefab/UI/InAct"), Vector3.zero, Quaternion.identity);
    //        //instaImg.transform.SetParent(canvas.transform);
    //        //instaImg.transform.localPosition = new Vector3(0, -160, 0);
    //        //viewImg = false;
    //    }
    //}

    ////プロパティ
    //public bool GetInShop
    //{
    //    get { return toShop; }
    //    set { toShop = value; }
    //}
}
