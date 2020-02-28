using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDataBase
{
    //設備名
    public Dictionary<string, string> shopName;

    //コンストラクタ
    public void Constructor()
    {
        shopName = new Dictionary<string, string>();
        shopName.Add("weapon", "bukiBill");
        shopName.Add("armor", "bouguBill");
        shopName.Add("item", "itemBill");
        shopName.Add("inn", "INN");
    }

    //コンストラクタ(データ用)
    public void Constructor(string[] data1,string[] data2)
    {
        shopName = new Dictionary<string, string>();
        for(int i=0;i<data1.Length;i++)
        {
            shopName.Add(data1[i], data2[i]);
        }
    }

}
