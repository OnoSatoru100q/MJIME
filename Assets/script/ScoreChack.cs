using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChack : MonoBehaviour
{
    public Text UIText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.y++;
        transform.position = pos;
     
    }
}
