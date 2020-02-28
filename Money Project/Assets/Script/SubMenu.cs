using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMenu : MonoBehaviour {

    //メニューディレクタースクリプト
    private MenuDirector MDScript;

    //キャンバス
    [SerializeField]
    private GameObject canvas;

    //カーソル
    [SerializeField]
    private GameObject cursor;

    private GameObject prefab;
    private RectTransform transe;

	// Use this for initialization
	void Start ()
    {
        MDScript = this.GetComponent<MenuDirector>();

        //初期化
        prefab = null;
        transe = null;
	}
	
	// Update is called once per frame
	void Update ()
    {
     //   //メニュー項目に入ったなら
	    //if(MDScript.flag)
     //   {
     //       if (prefab == null)
     //       {
     //           prefab = Instantiate(cursor);
     //           prefab.transform.SetParent(canvas.transform, false);
     //           transe = prefab.GetComponent<RectTransform>();
     //       }

     //       switch(MDScript.GetCursorNum())
     //       {
     //           case 0:
     //               //初期座標変更
     //               //各種項目のアイコンと名前を表示
     //               //決定時の挙動
     //               //項目によってはさらなるサブ画面が必要
     //               break;
     //           case 1:
     //               break;
     //           case 2:
     //               break;
     //           case 3:
     //               break;
     //           case 4:
     //               break;
     //       }

     //       //左右上下移動
     //   }
     //   else //メニュー項目から戻ったなら
     //   {
     //       //初期化
     //       if (prefab != null)
     //       {
     //           Destroy(prefab);
     //           //Destroy(cursor);
     //       }
     //       transe = null;
     //   }

     //   //サブメニューから戻る
     //   if(Input.GetButtonDown("Button2"))
     //   {
     //       MDScript.flag = false;
     //   }

     //   //メニューを閉じる
     //   if (Input.GetButtonDown("Pause") && MDScript.flag == true)
     //   {
     //       MDScript.flag = false;
     //   }
    }
}
