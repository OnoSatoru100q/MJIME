using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gg : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue1;
    public Canvas Menue;
    public Canvas Canvas;
    public GameObject Cube;



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