using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MItOnOff : MonoBehaviour
{

    public bool OnOff = true;
    public GameObject WallObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ON()
    {
        //キャッチャーミット操作（Zが1で隠し、0でオープン)
        // transformを取得
        Transform WallTransform = WallObject.transform;

        // 座標を取得
        Vector3 pos0 = WallTransform.position;

        pos0.z = 1f;

        WallTransform.position = pos0;  // 座標を設定
    }

    void OFF()
    {
        //キャッチャーミット操作（Zが1で隠し、0でオープン)
        // transformを取得
        Transform WallTransform = WallObject.transform;

        // 座標を取得
        Vector3 pos0 = WallTransform.position;

        pos0.z = 0f;

        WallTransform.position = pos0;  // 座標を設定
    }



}
