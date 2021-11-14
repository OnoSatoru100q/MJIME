using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXdir : MonoBehaviour
{
    public float lenght = 4.0f;
    public float speed = 2.0f;
    private Vector3 startPos;
    public bool negative = false;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        if(negative == true)
        {
            speed = -speed;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3((Mathf.Sin((Time.time)*speed)*lenght + startPos.x), startPos.y, startPos.z);
    }
}
