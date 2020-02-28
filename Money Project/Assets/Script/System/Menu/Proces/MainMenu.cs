using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MenuScript
{
    //プレハブ名
    [SerializeField]
    private List<string> prefabName;

    //メニューオブジェクト
    private GameObject menuUI = null;
    private GameObject instance = null;

    private StatusScript sScript;

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        base.Initialise();
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuUI)
        {
            //カーソル移動
            base.MoveCursor();

            //決定判定
            if (base.GetKettei())
            {
                //各項目のメニュー生成
                CreateMenu();
            }
        }
        else
        {
            //メニューを閉じる
            CloseMenu();
        }
    }

    //リストメニューの生成
    private void CreateMenu()
    {
        string prefab = prefabName[base.movePointY];

        if (menuUI == null)
        {
            //オブジェクトの生成
            menuUI = Resources.Load<GameObject>("Prefab/UI/Canvas/Menu/" + prefab);
            //オブジェクトのインスタンス化
            instance = Instantiate(menuUI, this.transform);
            //リネーム
            instance.name = prefab;
            instance.GetComponent<StatusDirector>().DisplayState(sScript.info());
        }
    }

    //メニューを閉じる
    private void CloseMenu()
    {
        //キャンセルボタンが押されたら
        if(base.GetCancel())
        {
            menuUI = null;
            Destroy(instance);
            instance = null;
        }
    }

    public void script(StatusScript status)
    {
        sScript = status;
    }
}
