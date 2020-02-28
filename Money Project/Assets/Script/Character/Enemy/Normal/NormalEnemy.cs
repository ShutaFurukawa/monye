using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class NormalEnemy : EnemyDirector
{
    //自身の生成
    static public NormalEnemy Create(Transform parent)
    {
        //オブジェクトの生成
        GameObject model = (GameObject)Resources.Load("Prefab/Model/Enemy");
        //オブジェクトのインスタンス化
        GameObject instance = Instantiate(model, parent);
        //親子関係の構築
        instance.transform.parent = parent;
        //リネーム
        instance.name = "Enemy";
        return instance.GetComponent<NormalEnemy>();
    }

    //コンストラクタ
    public NormalEnemy()
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
        
    }

    //デバッグ機能
    private string[] debugText = new string[14];
    public void NormalEnemyDebug()
    {
        //テキスト設定
        debugText[0] = "HP:" + hp.ToString();
        debugText[1] = "MP:" + mp.ToString();
        debugText[2] = "攻撃力:" + atk.ToString();
        debugText[3] = "筋力:" + str.ToString();
        debugText[4] = "防御力:" + def.ToString();
        debugText[5] = "体力:" + vit.ToString();
        debugText[6] = "器用さ:" + dex.ToString();
        debugText[7] = "素早さ:" + agi.ToString();
        debugText[8] = "運:" + luc.ToString();
        debugText[9] = "Level:" + level.ToString();
        debugText[10] = "所持金:" + money.ToString();

        debugText[11] = "PosX:" + transform.position.x.ToString();
        debugText[12] = "PosY:" + transform.position.y.ToString();
        debugText[13] = "PosZ:" + transform.position.z.ToString();
    }

    public string [] status
    {
        get { return debugText; }
    }
}
