using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectMove : MonoBehaviour
{
    Vector3 direction = new Vector3(0f, 0f, 1f);    //目的地 （カメラ位置）
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, direction, step);

    }
}
