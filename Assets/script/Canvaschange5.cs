using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvaschange5 : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue2;
   


    // Use this for initialization
    void Start()
    {
        //初めはBottonをオフにしておく
        Menue2.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオフだったら
        if (!Menue2.enabled)
        {
            //サブカメラをオンにする
            Menue2.enabled = true;

            

        }

    }
}