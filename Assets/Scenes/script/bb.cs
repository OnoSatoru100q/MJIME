using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bb : MonoBehaviour
{
    //カメラを格納する変数
    public Camera Camera;
    public Camera subCamera2;
    public Camera subCamera;
    public Camera subCamera1;
    public Camera subCamera3;


    public GameObject Canvas;
    // Use this for initialization
    void Start()
    {
        //初めはサブカメラをオフにしておく
        subCamera2.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!subCamera2.enabled)
        {
            //サブカメラをオンにして
            subCamera2.enabled = true;
            //カメラをオフにする
            Camera.enabled = false;
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera2;
        }
        //もしサブカメラがオンだったら
        else
        {
            //サブカメラをオフにして
            subCamera2.enabled = false;
            subCamera.enabled = false;
            subCamera1.enabled = false;
            subCamera3.enabled = false;
            //サブカメラ１をオンにする
            Camera.enabled = true;
            //キャンバスを映すカメラをサブカメラ１オブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}