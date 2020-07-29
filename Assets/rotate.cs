using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
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
        if(pos.z > 3f)
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
