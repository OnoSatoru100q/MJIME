using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvaschange7 : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue1;
    public Canvas Next;



    // Use this for initialization
    void Start()
    {
        //初めはBottonをオフにしておく
        Next.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオフだったら
        if (!Next.enabled)
        {
            //サブカメラをオンにする
            Next.enabled = true;

            Menue1.enabled = false;
            

        }

    }
}