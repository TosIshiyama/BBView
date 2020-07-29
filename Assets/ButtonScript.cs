using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonScript : MonoBehaviour
{

    public GameObject BallObject;   // ボールのオブジェクト取得
    public GameObject WallObject;   // 壁（ミット）のオブジェクト取得
   // public GameObject SpeedText;

   // public InputField inputField;
    public Text text;

    GameObject Ball;
    VectMove script;

    // Start is called before the first frame update
    void Start()
    {

        Ball =  GameObject.Find("Ball_Sphere");
        script = Ball.GetComponent<VectMove>();

        //inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

        text.text = script.speed.ToString();    //動いていない？
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnTap()
    {
        Debug.Log("Tap!");  // ログを出力

        //ボール位置操作
        // transformを取得
        Transform BallTransform = BallObject.transform;

        // 座標を取得
        Vector3 pos = BallTransform.position;

        pos.z = -1f;

        BallTransform.position = pos;  // 座標を設定

    }
    public void OffTap()
    {
        Debug.Log("離した!");  // ログを出力

        //ボール位置操作
        // transformを取得
        Transform BallTransform = BallObject.transform;

        // 座標を取得
        Vector3 pos = BallTransform.position;

        pos.z = 250f;

        BallTransform.position = pos;  // 座標を設定

    }

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        Debug.Log("押された!");  // ログを出力


        int i = 0;
        string s = text.text;
        bool result = int.TryParse(s, out i); //i now = 108  

        if (i >0) { 

            //int num1 = int.Parse(text.text);

            Debug.Log(i);  // ログを出力
            script.speed = i;

        }

    }

}
