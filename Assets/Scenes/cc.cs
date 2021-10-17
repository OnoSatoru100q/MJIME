using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cc : MonoBehaviour
{
    //カメラを格納する変数
    public Camera Camera;
    public Camera subCamera;
    public Camera subCamera1;
    public Camera subCamera2;
    public Camera subCamera3;
    //キャンバスを格納
    public GameObject Canvas;
    // Use this for initialization
    void Start()
    {
        //初めはサブカメラをオフにしておく
        subCamera.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!subCamera.enabled)
        {
            //サブカメラをオンにして
            subCamera.enabled = true;
            //カメラをオフにする
            Camera.enabled = false;
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;
        }
        //もしサブカメラがオンだったら
        else
        {
            //サブカメラをオフにして
            subCamera.enabled = false;
            //サブカメラ１をオンにする
            subCamera1.enabled = true;
            //キャンバスを映すカメラをサブカメラ１オブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera1;
        }
        //もしサブカメラ1がオンだったら
        /* if (subCamera1.enabled)
          {
              //サブカメラ1をオフにして
              subCamera1.enabled = false;
              //サブカメラ２をおんにする
              subCamera2.enabled = true;
              Canvas.GetComponent<Canvas>().worldCamera = subCamera2;
          }
         //もしサブカメラ2がオンだったら
          else
          {
              //サブカメラ２をオフにする
              subCamera2.enabled = false;
              //カメラをオンにする
              Camera.enabled = true;
              Canvas.GetComponent<Canvas>().worldCamera = Camera;
          }*/
    }
}
