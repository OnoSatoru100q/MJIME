using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChack : MonoBehaviour
{
    
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
