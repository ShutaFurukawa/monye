using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Text[] skills = new Text[4];

    //スキル番号
    private int skillNum = 0;

    //実行する処理
    private List<System.Action> ability = new List<System.Action>(4); 

    //実行するスキルを設定する関数
    public void  AddSkill(int number,System.Action act)
    {
        ability[number] = act;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Button1"))
        {
            skills[0].text = "SKILL1 ACTIVE";
            //ability[0]();
        }
        else
        {
            skills[0].text = "SKILL1";
        }

        if (Input.GetButton("Button2"))
        {
            skills[1].text = "SKILL2 ACTIVE";
            //ability[1]();
        }
        else
        {
            skills[1].text = "SKILL2";
        }

        if (Input.GetButton("Button3"))
        {
            skills[2].text = "SKILL3 ACTIVE";
            //ability[2]();
        }
        else
        {
            skills[2].text = "SKILL3";
        }

        if (Input.GetButton("Button4"))
        {
            skills[3].text = "SKILL4 ACTIVE";
            //ability[3]();
        }
        else
        {
            skills[3].text = "SKILL4";
        }

    }
}
