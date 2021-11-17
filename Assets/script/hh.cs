using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hh : MonoBehaviour
{
    //Buttonを格納する変数
    public Canvas Menue1;
    public Canvas Menue;
    public Canvas Canvas;
   



    // Use this for initialization
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
    }
    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしButtonがオンだったら
        if (Menue1.enabled)
        {
            //サブカメラをオフにする
            Menue1.enabled = false;
            Menue.enabled = false;
            Canvas.enabled = true;
            

}
       
    }
}