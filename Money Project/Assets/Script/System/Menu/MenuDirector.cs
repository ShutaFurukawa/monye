using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDirector : MonoBehaviour {

    //メニュープレハブ
    private GameObject menu = null;
    //インスタンスオブジェクト
    private GameObject instance = null;

    private StatusScript staScript;

    //オープン判定
    private bool menuOpen = false;
    private bool stop = false;

    // Use this for initialization
    void Start ()
    {
        staScript = this.GetComponent<StatusScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //動作判定
        StopUpdate();

        //動作停止中なら以下の処理を行わない
        if(stop)
        {
            //動作停止中にキャンセルボタンを押したら
            if (Input.GetButtonDown("Button1"))
            {
                //動作再開
                stop = false;
            }
            return;
        }

        //ポーズボタン押したら
        if (Input.GetButtonDown("Pause"))
        {
            //ポーズ判定
            menuOpen = !menuOpen;
        }

        //メニュー開いてるときにキャンセルボタンを認識させる
        if (menuOpen && Input.GetButtonDown("Button1"))
        {
            menuOpen = !Input.GetButtonDown("Button1");
        }

        //メニュー表示切替
        OpenMenu(menuOpen);
    }

    //メニューボタン押下判定
    private void GetMenu()
    {
        //メニューボタンを押したら
        if(Input.GetButtonDown("Pause"))
        {
            //メニュー判定
            menuOpen = !menuOpen;
        }
    }

    //メニューを開く
    private void OpenMenu(bool flag)
    {
        if (flag)
        {
            if (menu == null)
            {
                staScript.SetStatus();
                //オブジェクトの生成
                menu = Resources.Load<GameObject>("Prefab/UI/Canvas/PlayerMenu");
                //オブジェクトのインスタンス
                instance = Instantiate(menu);
                //リネーム
                instance.name = "PlayerMenu";
                instance.GetComponent<StatusDirector>().DisplayState(staScript.info());
                instance.GetComponent<MainMenu>().script(staScript);
            }
        }
        else
        {
            //初期化
            menu = null;
            Destroy(instance);
            instance = null;
        }
    }

    //動作停止関数
    public void StopUpdate()
    {
        //決定ボタンを押したら
        if (Input.GetButtonDown("Button4") && menuOpen)
        {
            //動作停止
            stop = true;
        }
    }
}
