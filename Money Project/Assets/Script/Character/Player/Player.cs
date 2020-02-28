using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : PlayerDirector
{
    //プレイヤー情報
    private float[] status = new float[13];

    //自身の生成
    static public Player Create(Transform parent)
    {
        //オブジェクトの生成
        GameObject model = Resources.Load<GameObject>("Prefab/Model/Player");
        //オブジェクトのインスタンス化
        GameObject instance = Instantiate(model, parent);
        //親子関係の構築
        instance.transform.parent = parent;
        //リネーム
        instance.name = "Player";
        return instance.GetComponent<Player>();
    }

    //デフォルトコンストラクタ
    public Player()
    {
        //初期値設定
        base.Initialise();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //仮移動関数
        base.Move();
        //**操作系を別スクリプトで統一**//
        //**操作系メソッドから処理を行うようにする**//
    }

    public void PlayerStatus()
    {
        //テキスト設定
        status[0] = hp;
        status[1] = mp;
        status[2] = atk;
        status[3] = str;
        status[4] = def;
        status[5] = vit;
        status[6] = dex;
        status[7] = agi;
        status[8] = luc;
        status[9] = money;

        status[10] = transform.position.x;
        status[11] = transform.position.y;
        status[12] = transform.position.z;
    }

    public float[] statusInfo
    {
        get { return status; }
    }
}
