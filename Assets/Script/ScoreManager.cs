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
    public bool setlevel3 = false;

    public GameObject level1;
    public GameObject level2obj1;
    public GameObject level2obj2;
    private int selectlevel;
    Scene m_Scene;

    //
    public GameObject player1;
    public GameObject player2;

    // Use this for initialization
    void Start () {
        m_Scene = SceneManager.GetActiveScene();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

    }
	
	// Update is called once per frame
	void Update () {


        if (m_Scene.name == "Level2")
        {
            setlevel1 = false;
            setlevel2 = true;
            setlevel3 = false;
            gameSlider.value = 2;
            if (scoreCounter > 100 && setlevel2)
            {
                PlayerPrefs.SetInt("movetolevel3", 3);
                SceneManager.LoadScene("Level3");
               // Destroy(level2obj1);
               // Destroy(level2obj2);
              
               
            }
        }
        
        if (m_Scene.name == "Game")
            setlevel1 = true;

        if (m_Scene.name == "Level3")
        {
            setlevel3 = true;
            gameSlider.value = 3;
            if(scoreCounter>40 && setlevel3)
            {
                setlevel1 = false;
                setlevel2 = false;
                setlevel3 = true;
                PlayerPrefs.SetInt("movetolevel40", 4);
                Debug.Log("write code for level4");
                  

            }
            //add level4 code here

        }


        if (scoreCounter > 55 && setlevel1)
        {
            
             Destroy(level1);
            
           PlayerPrefs.SetInt("movetolevel2", 2);
           SceneManager.LoadScene("Level2");
            
        }



    }

    public void AddScore(int score)
    {
        scoreCounter += score;
        scoreText.text = scoreCounter.ToString();
        FindObjectOfType<collision>().AddScoretext(scoreCounter);

        if (player1.activeInHierarchy)
        {
          player1.GetComponent<play1>().AddScore(score);
        }
        else if (player2.activeInHierarchy)
        {
            player2.GetComponent<play2>().AddScore(score);
        }
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
