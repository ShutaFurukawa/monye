using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //ゲーム全体の管理を行うメソッド
    //設備の位置、敵の出現やプレイヤーの初期位置などはＣＳＶで管理する（予定）

    //デバッグオブジェクト
    [SerializeField]
    private GameObject debugDire;

    //カメラ
    [SerializeField]
    private FollowCamera camera;

    //プレイヤー出現オブジェクト
    [SerializeField]
    private Transform PlayerSponer;
    //設備名
    [SerializeField]
    private List<string> shopName;

    //プレイヤー
    private Player player;
    //設備メソッド
    private GameObject[] shopMehod;
    public ShopDataBase shopData = new ShopDataBase();

    //表示管理メソッド
    private DisplayDirector displayObj;

    void Awake()
    {
        //メソッドインスタンス
        shopMehod = new GameObject[shopName.Count];
        displayObj = this.GetComponent<DisplayDirector>();

        //コンストラクタ
        shopData.Constructor();
    }

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤー設定
        InitialisePlayer();

        //設備生成
        InitialiseShop();
        displayObj.Initialise();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //キャラクター関係初期化関数
    private void InitialisePlayer()
    {
        //プレイヤーの生成
        player = Player.Create(PlayerSponer);
        //追従カメラの対象設定
        camera.AddTarget(player.gameObject);

    }

    //施設初期化関数
    private void InitialiseShop()
    {
        for (int i = 0; i < shopName.Count; i++)
        {
            //生成する設備と、表示するUIの設定
            shopMehod[i] = Shop.Creat(shopName[i], displayObj.CreateUIs);
            //位置設定
            //shopMehod[i].transform.position = Vector3.zero;
        }
    }
}
