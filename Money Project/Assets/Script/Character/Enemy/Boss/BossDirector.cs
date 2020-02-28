using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDirector : MonoBehaviour {

    //ボスステータス
    private Dictionary<string, int> state = new Dictionary<string, int>()
    {
        {"hp",100 },
        {"mp",10 },
        {"atk",1 },
        {"dfe",1 },
        {"dex",1 },
        {"agi",1 },
    };

    //体力
    public int HP { get { return state["hp"]; } }
    //精神力
    public int MP { get { return state["hp"]; } }
    //攻撃力
    public int ATK { get { return state["atk"]; } }
    //防御力
    public int DFE { get { return state["dfe"]; } }
    //器用度
    public int DEX { get { return state["dex"]; } }
    //素早さ
    public int AGI { get { return state["agi"]; } }

}
