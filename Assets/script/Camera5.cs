using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera5: MonoBehaviour
{
    //カメラを格納する変数
    public Camera Camera;
    public Camera subCamera;
    public Camera subCamera1;
    public Camera subCamera2;
    public Camera subCamera3;

    public GameObject Canvas;
    // Use this for initialization
    void Start()
    {
        //初めはサブカメラをオフにしておく
        subCamera.enabled = false;
        subCamera1.enabled = false;
        subCamera2.enabled = false;
        subCamera3.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!Camera.enabled)
        {
            //サブカメラをオンにして
            Camera.enabled = true;
            //カメラをオフにする
            subCamera.enabled = false;
            subCamera1.enabled = false;
            subCamera2.enabled = false;
            subCamera3.enabled = false;
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}
        

