using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    // ボールを回転させる

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Transform BallTransform = GetComponent<Transform>();

        Vector3 pos = BallTransform.position;
        if(pos.z > 3f)  // 視点ぎりぎりまできたら回転を停止
        {
            //Debug.Log(pos.z);  // ログを出力

            GetComponent<Rigidbody>().angularVelocity = Vector3.right * Mathf.PI;

        }
        else
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.right*0f;

        }
    }
}
