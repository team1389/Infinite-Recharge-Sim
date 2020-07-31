using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Power Cell")
        {
            count += 1;
            scoreText.text = "Score: " + count;
        }
    }
}
