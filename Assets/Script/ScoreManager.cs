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
    private bool gameover = false;
    public bool setlevel1=false;
    public bool setlevel2 = false;

    public GameObject level1;
    private int selectlevel;
    Scene m_Scene;

    // Use this for initialization
    void Start () {
        m_Scene = SceneManager.GetActiveScene();
      
    }
	
	// Update is called once per frame
	void Update () {


        if (m_Scene.name == "Level2")
        {
            setlevel1 = false;
            setlevel2 = true;
        }
        if (m_Scene.name == "Game")
            setlevel1 = true;

        if (scoreCounter > 50 && setlevel1)
        {
            Destroy(level1);
            PlayerPrefs.SetInt("movetolevel2", 2);
            SceneManager.LoadScene("Level2");
            gameSlider.value = 2;
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

    public int scoreCouunter()
    {
        return scoreCounter;
    }
}
