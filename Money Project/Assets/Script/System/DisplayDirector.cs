using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDirector : MonoBehaviour
{
    //画面に動的表示するＵＩ系の管理オブジェクト
    //画像表示用の親
    [SerializeField]
    private Transform canvas;
    //表示用ＵＩリスト
    private Dictionary<string, string> UIList = new Dictionary<string, string>();

    //UIの生成
    public GameObject CreateUIs(string UIName)
    {
        //UIの生成
        GameObject dispObj = Resources.Load<GameObject>("Prefab/UI/System/" + UIName);
        //オブジェクトのインスタンス化
        GameObject UIObj = Instantiate(dispObj, canvas);
        //親子関係の構築
        UIObj.transform.SetParent(canvas);
        //リネーム
        UIObj.name = UIName;

        return UIObj;
    }

    //UIリストの生成
    public void Initialise()
    {
        UIList.Add("shop", "InShop");
    }
}
