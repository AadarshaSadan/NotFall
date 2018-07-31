using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int scoreCounter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore(int score)
    {
        scoreCounter += score;
        scoreText.text = scoreCounter.ToString();
        FindObjectOfType<collision>().AddScoretext(scoreCounter);
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
