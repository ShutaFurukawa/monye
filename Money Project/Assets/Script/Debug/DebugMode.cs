using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMode : MonoBehaviour {

    ////エネミー出現オブジェクト
    [SerializeField]
    private Transform EnemySponar;

    //デバッグテキスト（エネミー）
    [SerializeField]
    private List<Text> enemyText;

    //**基底クラスはインスタンス化しない**//
    //エネミー生成
    private NormalEnemy enemy;

    //メニューディレクター
    [SerializeField]
    GameSystem sys;

	// Use this for initialization
	void Start ()
    {
        //エネミーの生成
        enemy = NormalEnemy.Create(EnemySponar);
	}
	
	// Update is called once per frame
	void Update ()
    {
        enemy.NormalEnemyDebug();

        //if (!sys.openFlag)
        //{
            for (int i = 0; i < enemy.status.Length; i++)
            {
                enemyText[i].text = enemy.status[i];
                enemyText[i].enabled = true;
            }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < enemy.status.Length; i++)
        //        {
        //            enemyText[i].enabled = false;
        //        }
        //    }
    }
}
