using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class ScoreChange : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    public string ChangeScene = "Level 2";
    private AudioSource audio;
    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        currentScore = 0;
        HandleScore();
    }

    private void HandleScore()
    {
       scoreText.text = "Player Score: " + currentScore; 
       
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(ChangeScene);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Circle")
        {
            currentScore++; 
            HandleScore();
            audio.Play();
            
        }
    }
    private void Update()
    {
        if (currentScore == 10)
        {
            LoadScene();
        }
    }
}