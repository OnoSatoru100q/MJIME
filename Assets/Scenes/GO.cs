using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GO : MonoBehaviour
{
    public Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameOver")
        {
            Destroy(this.gameObject);
            gameOverText.text = "GameOver";
        }
      
    }
}
