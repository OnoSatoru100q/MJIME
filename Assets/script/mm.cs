using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mm : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue1;
    public Canvas Next;



    // Use this for initialization
    void Start()
    {
        //初めはBottonをオフにしておく
        
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオフだったら
        if (Next.enabled)
        {
            //サブカメラをオンにする
            Next.enabled = false;

            Menue1.enabled = true;


        }

    }
}