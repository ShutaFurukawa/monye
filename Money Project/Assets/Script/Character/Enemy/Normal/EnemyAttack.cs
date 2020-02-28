using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//攻撃クラス
public class EnemyAttack : MonoBehaviour {

    //攻撃タイプ用変数
    public enum ENEMY_TYPE
    {
        NONE,
        ATTACKER,
        SUPPORTER,
        BALANCER
    };

    [SerializeField, Range(0, 180)]
    private float waitTime = 0.0f;
    private float atkTime = 0.0f;

    // Update is called once per frame
	public void SetAttack(ENEMY_TYPE type, EnemyAI script)
    {
        //攻撃対象が視界内に入っているなら
        if (!script.GetNeary() && script.GetFlag())
        {
            //攻撃タイプ判別
            switch (type)
            {
                //近距離
                case ENEMY_TYPE.ATTACKER:
                    if (AttackWait(waitTime))
                    {
                        Debug.Log("Attack");
                    }

                    break;
                //サポート
                case ENEMY_TYPE.SUPPORTER:
                    break;
                //バランス
                case ENEMY_TYPE.BALANCER:
                    break;
                //それ以外
                default:
                    break;
            }
        }
	}

    //攻撃間隔設定関数
    private bool AttackWait(float waitTime)
    {
        //攻撃クールタイム中
        if (atkTime <= waitTime)
        {
            //待機時間進行
            atkTime += Time.deltaTime;
            return false;
        }
        else
        {
            //待機時間初期化
            atkTime = 0;
            return true;
        }
    }
}
