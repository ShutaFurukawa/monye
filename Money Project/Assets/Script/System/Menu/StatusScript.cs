using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusScript : MonoBehaviour
{
    [SerializeField]
    private GameObject parent;
    private Player player;

    //ステータス
    private string[] status = new string[13];

    public void SetStatus()
    {
        player = parent.transform.GetComponentInChildren<Player>();
        player.PlayerStatus();

        status[0] = "HP:" + player.statusInfo[0].ToString();
        status[1] = "MP:" + player.statusInfo[1].ToString();
        status[2] = "攻撃力" + player.statusInfo[2].ToString();
        status[3] = "筋力" + player.statusInfo[3].ToString();
        status[4] = "防御力" + player.statusInfo[4].ToString();
        status[5] = "体力" + player.statusInfo[5].ToString();
        status[6] = "器用さ" + player.statusInfo[6].ToString();
        status[7] = "素早さ" + player.statusInfo[7].ToString();
        status[8] = "運" + player.statusInfo[8].ToString();
        status[9] = "所持金" + player.statusInfo[9].ToString();

        status[10] = "PosX:" + player.statusInfo[10].ToString();
        status[11] = "PosY:" + player.statusInfo[11].ToString();
        status[12] = "PosZ:" + player.statusInfo[12].ToString();
    }

    public string[] info()
    {
        return status;
    }

}
