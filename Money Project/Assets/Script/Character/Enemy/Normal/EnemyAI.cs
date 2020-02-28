using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour {

    //キャラクターにAIを実装する

    //オブジェクト用変数
    GameObject target;      //対象者

    //視界
    private EnemyVisibility EVScript;
    private Rigidbody rd;

    //追跡速度
    [SerializeField, Range(0, 1)]
    private float speed = 0;
    //旋回速度
    [SerializeField, Range(0, 5)]
    private float rotSpeed = 0;

    [SerializeField, Range(0, 10)]
    private float near = 0;

    //ラジアン計算関数
    public float ConvertToRadians(float degrees)
    {
        return degrees * (Mathf.PI / 180.0f);
    }

    //度計算関数
    public float ConvertToDegrees(float radians)
    {
        return radians * (180.0f / Mathf.PI);
    }


    //------------------------------------
    //スクリプト開始直後に実行される関数
    //------------------------------------
    void Start ()
    {
        rd = GetComponent<Rigidbody>();
        EVScript = GetComponent<EnemyVisibility>();
    }

    //------------------------------------
    //更新関数
    //------------------------------------
    void Update ()
    {
        //追跡
        Pursuit(target);

    }

    private void Pursuit(GameObject traget)
    {
        //追跡対象を代入
        target = EVScript.GetTraget;
        //追跡アルゴリズム
        Vector3 distance = Vector3.zero;

        //追跡対象が存在していて視界内に入ったなら
        if (target != null && EVScript.Flag)
        {
            //追跡対象に接近したら
            if (NearTarget(near))
            {
                //追跡対象のへの移動方向の設定
                distance = new Vector3(transform.position.x - target.transform.position.x, 0, transform.position.z - target.transform.position.z);


                //プレイヤーの方向に向く(少しずつ向きを変える)
                float step = rotSpeed * Time.deltaTime;
                Quaternion myq = Quaternion.LookRotation(-distance);
                transform.rotation = Quaternion.Lerp(transform.rotation, myq, step);
            }
        }

        //移動
        rd.velocity = -distance * speed;
    }

    //追跡対象接近判定関数
    private bool NearTarget(float nearVal)
    {
        if (EVScript.Distance >= nearVal)
        {
            return true;
        }
        return false;
    }

    public bool GetNeary()
    {
        return NearTarget(near);
    }

    public bool GetFlag()
    {
        return EVScript.Flag;
    }

}
