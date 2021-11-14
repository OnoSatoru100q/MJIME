using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ff : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue;
    public Canvas Canvas;
    

    
    // Use this for initialization
    void Start()
    {
        //初めはBottonをオフにしておく
        Menue.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオフだったら
        if (!Menue.enabled)
        {
            //サブカメラをオンにする
            Menue.enabled = true;
            Canvas.enabled = false;

        }
        //もしButtonがオンだったら
        else
        {
            //Buttoをオフにする
            Menue.enabled = false;
            
            //サブカメラ１をオンにする

        }
    }
}