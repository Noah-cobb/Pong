using System.Collections;
using UnityEngine.UI;
using UnityEngine;
public class ScoreChange : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    // Use this for initialization
    void Start()
    {
        currentScore = 0;
        HandleScore();
    }

    private void HandleScore()
    {
        scoreText.text = "Player Score: " + currentScore;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Circle")
        {
            currentScore++;
            HandleScore();
        }
    }
}