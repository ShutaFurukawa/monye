using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoScript : MonoBehaviour
{
    //ランダムな値を生成する関数
    public int CreatRandom(float min, float max, int level)
    {
        return (int)Random.Range(min, max + (min * level - min));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
