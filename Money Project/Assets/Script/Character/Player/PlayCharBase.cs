using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayCharBase
{
    public uint mianID;     //プレイヤーID

    public float HP=0f;        //命力
    public float MP=0f;        //精神力
    public float ATK=0f;       //攻撃力
    public float STR=0f;       //筋力
    public float DEF=0f;       //防御力
    public float VIT=0f;       //体力
    public float DEX=0f;       //器用さ
    public float AGI=0f;       //素早さ
    public float LUC=0f;       //運

    //デフォルトコンストラクタ
    public void Constructor()
    {
        //特に何もしない
    }

    //コンストラクタ
    public void Constructor(string[] data)
    {
        //データを参照 
        float.TryParse(data[0], out HP);        //命力
        float.TryParse(data[1], out MP);        //精神力
        float.TryParse(data[2], out ATK);       //攻撃力
        float.TryParse(data[3], out STR);       //筋力
        float.TryParse(data[4], out DEF);       //防御力
        float.TryParse(data[5], out VIT);       //体力
        float.TryParse(data[6], out DEX);       //器用さ
        float.TryParse(data[7], out AGI);       //素早さ
        float.TryParse(data[8], out LUC);       //運
    }

    //コピーコンストラクタ
    public void Constructor(PlayCharBase baseData)
    {
        //複製
        HP = baseData.HP;
        MP = baseData.MP;
        ATK = baseData.ATK;
        STR = baseData.STR;
        DEF = baseData.DEF;
        VIT = baseData.VIT;
        DEX = baseData.DEX;
        AGI = baseData.AGI;
        LUC = baseData.LUC;
    }
}



