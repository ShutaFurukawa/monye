using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵の基底クラスなので抽象化
public class EnemyDirector : MonoBehaviour
{
    //元データ
    public EnemyBase baseData = new EnemyBase();
    　
    //基本データ
    protected float hp = 0f;
    protected float mp = 0f;
    protected float atk = 0f;
    protected float str = 0f;
    protected float def = 0f;
    protected float vit = 0f;
    protected float dex = 0f;
    protected float agi = 0f;
    protected float luc = 0f;

    protected float speed = 0f;
    protected float rotate = 0f;

    //内部データ
    //所持金
    protected int money = 0;
    //レベル
    protected uint level = 0;


    protected Vector3 move = Vector3.zero;              //移動量
    protected Vector3 velocity = Vector3.zero;            //速力

    [SerializeField]
    protected Rigidbody rb;

    //共通処理

    //初期化関数
    protected void Initialise()
    {
        //データの初期化
        hp = baseData.HP;
        mp = baseData.MP;
        atk = baseData.ATK;
        str = baseData.STR;
        def = baseData.DEF;
        vit = baseData.VIT;
        dex = baseData.DEX;
        agi = baseData.AGI;
        luc = baseData.LUC;

        money = 0;
        level = 0;
    }

}
