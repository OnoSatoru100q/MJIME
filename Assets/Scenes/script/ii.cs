using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ii : MonoBehaviour
{
    //Buttonを格納する変数
   
    public Canvas Menue;
    




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
        if (Menue.enabled)
        {
            //サブカメラをオフにする
            Menue.enabled = false;
            
            


        }

    }
}