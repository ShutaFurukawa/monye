using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    //追跡対象
    GameObject targetObj;

    //追跡座標
    Vector3 targetPos;

    //カメラ旋回速度
    [SerializeField, Range(1f, 10f)]
    private float wheelSpeed = 1f;

    //追跡対象の設定
    public void AddTarget(GameObject target)
    {
        //対象オブジェクト
        targetObj = target;
        //対象の座標を代入
        targetPos = targetObj.transform.position;
    }

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        //カメラの移動
        FollowCam();

        //カメラの旋回
        RotateCam();
	}

    //対象の移動量分カメラを移動させる関数
    private void FollowCam()
    {
        //移動量計算
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;
    }

    //対象を軸にカメラを回転移動させる関数
    private void RotateCam()
    {
        //カメラ旋回ボタンを押したら
        if (Input.GetAxis("CameraHor") != 0)
        {
            //カメラの移動量
            float mouseInputX = Input.GetAxis("CameraHor") * wheelSpeed;

            //対象の位置のY座標を中心に回転する
            transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
        }
    }
}
