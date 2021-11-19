using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public Text gameOverText;
    public GameObject Retry;
    public GameObject title;
    bool x;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameOver")
        {
            Destroy(this.gameObject);
            gameOverText.text = "GameOver";
            Retry.SetActive(true);
            title.SetActive(true);
            ClickPositionCreatePrefabScript.GameEnd();
        }

        if (other.tag == "ScoreTag")
        {
            if (x)
            {
                return;
            }
            x = true;
            ClickPositionCreatePrefabScript.UpdateScore();
        }
      
    }
}
