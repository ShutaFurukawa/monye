using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    //**限定公開データ**//
    //カーソル
    [SerializeField]
    protected RectTransform cursorPos;
    //項目数
    [SerializeField]
    protected int menuY = 0;
    [SerializeField]
    protected int menuX = 0;
    //移動量
    [SerializeField]
    protected Vector3 move = Vector3.zero;

    //位置番号
    protected int movePointY;
    protected int movePointX;

    //**非公開データ**//
    //定数
    private const int INIT_NUM = 0;

    //カーソル初期位置
    private Vector3 initPos;
    //移動フラグ
    private bool moveFlag;
    //決定フラグ
    private bool kettei;
    //キャンセルフラグ
    private bool cancel;

    // Start is called before the first frame update
    protected void Initialise()
    {
        //初期値代入
        movePointX = 0;
        movePointY = 0;

        initPos = cursorPos.localPosition;

        kettei = false;
        moveFlag = false;
    }

    //カーソル移動関数
    protected void MoveCursor()
    {
        if (!moveFlag)
        {
            //上
            if (Input.GetAxis("MenuVer") > 0 && INIT_NUM < movePointY)
            {
                //番号を減らす
                movePointY--;
                moveFlag = true;
            }
            //下
            if (Input.GetAxis("MenuVer") < 0 && menuY - 1 > movePointY)
            {
                //番号を増やす
                movePointY++;
                moveFlag = true;
            }
            //右
            //左
        }

        if (Input.GetAxis("MenuVer") == 0 && moveFlag)
        {
            moveFlag = false;
        }

        //カーソル位置計算
        float X = move.x * movePointX;
        float Y = move.y * movePointY;
        Vector3 pos = new Vector3(X + initPos.x, Y + initPos.y, initPos.z);

        //移動
        cursorPos.localPosition = pos;
    }

    //決定取得関数
    protected bool GetKettei()
    {
        //決定フラグをＯＮにする
        kettei = Input.GetButtonDown("Button4");

        return kettei;
    }

    //キャンセル取得判定
    protected bool GetCancel()
    {
        //キャンセルフラグをＯＮにする
        cancel = Input.GetButtonDown("Button1");

        return cancel;
    }
}
