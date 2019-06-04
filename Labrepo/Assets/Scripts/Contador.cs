using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public int score;
    public Text ShowScore;
    // Start is called before the first frame update
    private void Update()
    {
        ShowScore.text = score.ToString();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }
}

