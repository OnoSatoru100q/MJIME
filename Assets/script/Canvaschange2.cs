using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvaschange2: MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue1;
    public Canvas Menue;
    public Canvas Canvas;
  



    // Use this for initialization
    void Start()
    {
        //初めはBottonをオフにしておく
        Menue1.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオフだったら
        if (!Menue1.enabled)
        {
            //サブカメラをオンにする
            Menue1.enabled = true;
            
            Menue.enabled = false;
            Canvas.enabled = false;

        }
      
    }
}