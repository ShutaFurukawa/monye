using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour {

    //enemy_1=標準的な性能を持った敵

    [SerializeField]
    GameObject director;

    EnemyDirector dirScript;
    EnemyAttack atkScript;
    EnemyAI aiScript;

    [SerializeField, Range(0, 100)]
    private int level = 1;
    private int money = 500;

    //各種ステータス用乱数
    private int randHP;     //体力
    private int randMP;     //精神力
    private int randFS;     //基礎ステータス

    //エネミーステータス
    private Dictionary<string, int> state = new Dictionary<string, int>()
    {
        {"hp", 0 },
        {"mp", 0 },
        {"atk",0 },
        {"dfe",0 },
        {"dex",0 },
        {"agi",0 },
    };

    ////攻撃タイプ
    //EnemyDirector.ENEMY_TYPE atkType = EnemyDirector.ENEMY_TYPE.NONE;

    // Use this for initialization
    void Start ()
    {
        //dirScript = director.GetComponent<EnemyDirector>();
        //atkScript = this.GetComponent<EnemyAttack>();
        //aiScript = this.GetComponent<EnemyAI>();

        ////ランダムな値を設定
        //randHP = dirScript.CreatRandom(10.0f, 50.0f,level);
        //randMP = dirScript.CreatRandom(2.0f, 20.0f, level);
        //randFS = dirScript.CreatRandom(1.0f, 10.0f, level);

        ////初期化
        //Initialise();

        //atkType = EnemyDirector.ENEMY_TYPE.ATTACKER;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //atkScript.SetAttack(atkType, aiScript);
	}

    //レベル
    public int Level { get { return level; } }
    //ステータス
    public int GetState(string name) { return state[name]; }
    //所持金
    public int GetMoney { get { return money; } }
    //初期化関数
    private void Initialise()
    {
        ////ステータス設定
        ////HP=多め
        //state["hp"] = Mathf.Abs((int)((dirScript.HP * level / dirScript.valueHP + dirScript.HP) + randHP));
        ////MP=微量
        //state["mp"] = Mathf.Abs((int)((dirScript.MP * level / dirScript.valueMP + dirScript.MP) - randMP));
        ////ATK=多め
        //state["atk"] = Mathf.Abs((int)(dirScript.ATK * level + dirScript.valueFS * randFS));
        ////DFE=普通
        //state["dfe"] = Mathf.Abs((int)(dirScript.DFE * level - dirScript.valueFS * randFS));
        ////DEX=少なめ
        //state["dex"] = Mathf.Abs((int)(dirScript.DEX * level / randFS + dirScript.valueFS));
        ////AGI=少なめ
        //state["agi"] = Mathf.Abs((int)(dirScript.AGI * level / dirScript.valueFS) + randFS);

        //money = money + level * 20;
    }
}
