using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyVisibility : MonoBehaviour {

    [SerializeField, Range(0.0f, 360.0f)]
    private float searchAngle = 0.0f;

    private float distance = 0.0f;
    private float searchCosTheta = 0.0f;

    //索敵対象
    private GameObject foundObj;
    private GameObject targetObj;

    private SphereCollider sphereCollider = null;

    //スクリプト
    private FanViwerState FVScript;

    private bool visitFlag = false;
    
    //あたり判定に侵入した時実行される関数
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //索敵対象を登録
            foundObj = other.gameObject;
        }
    }

    //あたり判定から抜けた時実行される関数
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //登録を解除
            foundObj = null;
        }
    }

    void Start()
    {
        FVScript = this.GetComponent<FanViwerState>();

        float searchRad = FVScript.fovX * 0.5f * Mathf.Deg2Rad;
        searchCosTheta = Mathf.Cos(searchRad);
    }

    // Update is called once per frame
    void Update ()
    {
        //視界判定
        UpdateFoundObject();
    }

    private void UpdateFoundObject()
    {
        targetObj = foundObj;

        bool isFound;
        //相対距離から視界内の計算をするかどうかの判定
        if (ComparisonDistance(targetObj))
        {
            //視界範囲内にいるかの判定
            isFound = ChackFoundObject(targetObj);
        }
        else
        {
            OnLost();
            //計算をしない
            return;
        }

        //発見状態
        if (isFound) { OnFound(targetObj); }
        //見失った状態
        else { OnLost(); }
    }

    //相対距離が視界の範囲内かを判定する関数
    private bool ComparisonDistance(GameObject target)
    {
        //オブジェクトが存在しているなら
        if (target != null)
        {
            //対象者と索敵者の相対距離
            distance = Vector3.Distance(this.transform.position, target.transform.position);

            //視界の大きさ(長さ)より相対距離が小さい場合
            if (FVScript.distance >= distance)
            {
                //視界の判定距離に存在する
                return true;
            }
            //視界の判定距離に存在しない
            return false;
        }
        //計算しない
        return false;
    }


    private bool ChackFoundObject(GameObject _target)
    {
        Vector3 targetPosition = _target.transform.position;
        Vector3 myPosition = transform.position;

        Vector3 myPositionXZ = Vector3.Scale(myPosition, new Vector3(1.0f, 0.0f, 1.0f));
        Vector3 targetPositionXZ = Vector3.Scale(targetPosition, new Vector3(1.0f, 0.0f, 1.0f));

        Vector3 toTargetFlatDir = (targetPositionXZ - myPositionXZ).normalized;
        Vector3 myForWard = transform.forward;

        if (!IsWithinRangeAngle(myForWard, toTargetFlatDir, searchCosTheta))
        {
            return false;
        }

        Vector3 toTargetDir = (targetPosition - myPosition).normalized;

        if(!IsHitRay(myPosition,toTargetDir,_target))
        {
            return false;
        }

        return true;
    }

    private bool IsHitRay(Vector3 _fromPosition,Vector3 _toTargetDir,GameObject _target)
    {
        //方向ベクトルがない場合は同じ位置にあるものだと判定する。
        if(_toTargetDir.sqrMagnitude<=Mathf.Epsilon)
        {
            return true;
        }

        RaycastHit onHitRay;
        if(!Physics.Raycast(_fromPosition,_toTargetDir,out onHitRay,SearchRadius))
        {
            return false;
        }
        if(onHitRay.transform.gameObject!=_target)
        {
            return false;
        }
        return true;
    }

    private bool IsWithinRangeAngle(Vector3 forwardDir,Vector3 _toTargetDir,float _cosTheta)
    {
        //方向ベクトルがない場合は同位置にあるものだと判断する
        if (_toTargetDir.sqrMagnitude <= Mathf.Epsilon)
        {
            return true;
        }

        float dot = Vector3.Dot(forwardDir, _toTargetDir);
        return dot >= _cosTheta;
    }

    //発見時実行関数
    private void OnFound(GameObject obj)
    {
        foundObj = obj;
        visitFlag = true;
    }

    //見失った時実行関数
    private void OnLost()
    {
        if (targetObj != null){ targetObj = null; }
        visitFlag = false;
    }

    public GameObject GetTraget
    {
        get { return foundObj; }
    }

    public bool Flag
    {
        get { return visitFlag; }
    }

    public float Distance
    {
        get { return distance; }
    }

    public float SearchAngle
    {
        get { return searchAngle; }
    }

    public float SearchRadius
    {
        get
        {
            if(sphereCollider==null)
            {
                sphereCollider = GetComponent<SphereCollider>();
            }
            return sphereCollider != null ? sphereCollider.radius : 0.0f;
        }
    }
}
