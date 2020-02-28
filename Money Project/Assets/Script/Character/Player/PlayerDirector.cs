using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//基底クラスになるので抽象化する
public class PlayerDirector : MonoBehaviour
{
    //元データ
    public PlayCharBase baseData = new PlayCharBase();

    //基本データ
    protected float hp = 0f;            //命力
    protected float mp = 0f;            //精神力
    protected float atk = 0f;           //攻撃力
    protected float str = 0f;           //筋力
    protected float def = 0f;           //防御力
    protected float vit = 0f;           //体力
    protected float dex = 0f;           //器用さ
    protected float agi = 0f;           //素早さ
    protected float luc = 0;            //運

    [SerializeField]
    protected float speed = 0f;         //速度
    [SerializeField]
    protected float rotate = 0f;        //旋回



    //内部データ
    //所持金
    protected int money = 0;

    protected Vector3 move = Vector3.zero;              //移動量
    protected Vector3 velocity=Vector3.zero;            //速力

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

        money = 500;
    }

    //移動関数
    protected void Move()
    {
        //移動量の代入
        move.x = Input.GetAxisRaw("ControlHor");
        move.z = Input.GetAxisRaw("ControlVer");

        Vector3 cameraForward = Vector3.zero;
        Vector3 moveForward = Vector3.zero;

        if (Mathf.Abs(move.x) >= 0.01f || Mathf.Abs(move.z) >= 0.01f)
        {
            //カメラの方向からX-Z平面の単位ベクトルを取得
            cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
            //カメラの向きから移動方向を決定
            moveForward = cameraForward * -move.z + Camera.main.transform.right * move.x;
        }

        rb.velocity = moveForward * speed;

        //キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            //方向変換する
            float step = rotate * Time.deltaTime;
            Quaternion myq = Quaternion.LookRotation(moveForward);
            transform.rotation = Quaternion.Lerp(transform.rotation, myq, step);
        }
    }
}
