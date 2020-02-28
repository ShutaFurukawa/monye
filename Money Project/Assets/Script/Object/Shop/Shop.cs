using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : ShopDirector
{
    //接近時表示UI
    private GameObject ShopUI;
    //接近判定
    private bool app = false;
    //入店判定
    private bool inShop = false;

    //衝突判定
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ApproachShopUI();
            app = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ReleseUI();
            app = false;
            inShop = false;
        }
    }

    //設備UI表示判定
    private void ApproachShopUI()
    {
        //UIのIDを渡して表示
        ShopUI = act(id);
    }

    //初期化用関数
    private void ReleseUI()
    {
        Destroy(ShopUI);
        ShopUI = null;
    }

    //入店判定
    private void ToShop()
    {
        //アクションボタンを押す
        if(Input.GetButtonDown("Button1"))
        {
            //店の入り口付近に居るなら
            if(app)
            {
                //入店
                inShop = true;
            }
        }
    }

    public bool Approach
    {
        get { return app; }
    }
    public bool Join
    {
        get { return inShop; }
    }
}
