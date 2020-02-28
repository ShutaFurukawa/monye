using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//設備基底クラス
public class ShopDirector : MonoBehaviour
{
    //ここから各種設備を生成
    //IDオブジェクト
    protected string id = "shop";

    //UI表示関数登録用
    static protected System.Func<string,GameObject> act;

    //指定した設備の生成
    static public GameObject Creat(string name, System.Func<string,GameObject> action)
    {
        //生成用オブジェクト
        GameObject model = null;
        //インスタンスオブジェクト
        GameObject instanse = null;
        act = action;

        //ショップの生成
        if (!model && !instanse)
        {
            //オブジェクトの生成
            model = Resources.Load<GameObject>("Prefab/Model/Shop/" + name);
            //オブジェクトのインスタンス化
            instanse = Instantiate(model);
            //リネーム
            instanse.name = name;
        }
        else
        {
            //エラーメッセージ
            Debug.Log("error : Not initialise shop model!!");
        }

        return instanse;
    }

}
