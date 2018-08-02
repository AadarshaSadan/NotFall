using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int scoreCounter;
    public Slider gameSlider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreCounter > 50)
        {
            gameSlider.value = 2;
        }
        if(scoreCounter>70)
        {
            gameSlider.value = 3;
        }
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
