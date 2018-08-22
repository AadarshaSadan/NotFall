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
    public  bool setlevel1=false;
    public  bool setlevel2 = false;
    public  bool setlevel3 = false;
    public  bool setlevel4 = false;
    public  bool setlevel5 = false;
    public  bool setlevel6 = false;
     public bool setlevel7 = false;
    public bool setlevel8 = false;
    public bool setlevel9 = false;
    public bool setlevel10 = false;
    public bool setlevel11 = false;
    public bool setlevel12 = false;
    public bool setlevel13 = false;
    public bool setlevel14 = false;
    public bool setlevel15 = false;
    public bool setlevel16 = false;
    public bool setlevel17 = false;
    public bool setlevel18 = false;
    public bool setlevel19 = false;
    public bool setlevel20 = false;

    public float delayBeforeloading = 10f;

    private float timeElapsed;
 
    private int selectlevel;
    private Scene m_Scene;

    //
    public GameObject player1;
    public GameObject player2;
    private GameObject levelName;
   
    // Use this for initialization
    void Start ()
    {
       levelName = GameObject.Find("LevelName");
        m_Scene = SceneManager.GetActiveScene();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        // PlayerPrefs.SetInt("movetolevel", 1);
        StartCoroutine(WaitBeforeLoding());
    }
	IEnumerator WaitBeforeLoding()
    {
        levelName.SetActive(true);
        levelName.GetComponent<Text>().text = m_Scene.name;
        yield return new WaitForSeconds(2f);
        levelName.SetActive(false);
      
    }
  


	// Update is called once per frame
	void Update () {
        
       //  Debug.Log(timeElapsed);
       
        //The logic behind level transaction
        //first set boolen  for each level
        //get scorecounter and current scene name
        //and load next scene
        //destroy privious game object

        //for game scene to level one scene  
        if (m_Scene.name == "Level1")
            setlevel1 = true;

        gameSlider.value = scoreCounter;
        if (scoreCounter >55 && setlevel1)//default score 55
        {
           
            SceneManager.LoadScene("Level2");
            PlayerPrefs.SetInt("level1cleared", 1);

        }

        
     //from level one to level two
           if (m_Scene.name == "Level2")
        {
            setlevel1 = false;
            setlevel2 = true;
            setlevel3 = false;
            gameSlider.value = scoreCounter;
            if (scoreCounter > 100 && setlevel2)//default score 100
            {
                PlayerPrefs.SetInt("level2cleared", 2);
                SceneManager.LoadScene("Level3");
               // Destroy(level2obj1);
               // Destroy(level2obj2);
              
               
            }
        }

        if (m_Scene.name == "Level3")
        {
            gameSlider.value = scoreCounter;
            setlevel3 = true;
            if(scoreCounter>40 && setlevel3)//default score 40
            {
                setlevel1 = false;
                setlevel2 = false;
                setlevel3 = true;
                PlayerPrefs.SetInt("level3cleared", 3);
                SceneManager.LoadScene("Level4");

            }
            

        }

      
        if(m_Scene.name=="Level4")
        {
            setlevel3 = false;
            setlevel4 = true;
            gameSlider.value = scoreCounter;
            //gameSlider.value = 4;
            if (scoreCounter>19 && setlevel4)//default score 19
            {
                setlevel5 = true;
                PlayerPrefs.SetInt("level4cleared", 4);
                SceneManager.LoadScene("Level5");
            }

        }

        if (m_Scene.name == "Level5")
        {
            //gameSlider.value = 5;
            setlevel4 = false;
            setlevel5 = true;
            gameSlider.value = scoreCounter;
            if (scoreCounter > 60 && setlevel5)//default 60 score
            {
               
                PlayerPrefs.SetInt("level5cleared", 5);
                SceneManager.LoadScene("Level6");
               
            }

        }

        if (m_Scene.name == "Level6")
        {
            //gameSlider.value = 6;
            gameSlider.value = scoreCounter;
            setlevel5 = false;
            setlevel6 = true;
            if (scoreCounter > 10 && setlevel6)//default 10 score
            {
                Debug.Log("write the code for level 6");
                PlayerPrefs.SetInt("level6cleared", 6);
                SceneManager.LoadScene("Level7");
                //Debug.Log("write the code for level 6");
            }

        }
        if (m_Scene.name == "Level7")
        {
            gameSlider.value = scoreCounter;
            //gameSlider.value = 7;
            setlevel6 = false;
            setlevel7 = true;
            if (scoreCounter > 100 && setlevel7)//default 100 score
            {
                 
               PlayerPrefs.SetInt("level7cleared", 7);
                SceneManager.LoadScene("Level8");
                //Debug.Log("write the code for level 6");
            }

        }
        if (m_Scene.name == "Level8")
        {
            gameSlider.value = scoreCounter;
            setlevel7 = false;
            setlevel8 = true;
            if (scoreCounter > 20 && setlevel8)//default 100 score
            {
                Debug.Log("write the code for level 8");
                PlayerPrefs.SetInt("level8cleared", 8);
                SceneManager.LoadScene("Level9");

            }

        }

        if (m_Scene.name == "Level9")
        {
            gameSlider.value = scoreCounter;
            setlevel8 = false;
            setlevel9 = true;
            if (scoreCounter >45 && setlevel9)//default 100 score
            {
                Debug.Log("write the code for level 8");
                PlayerPrefs.SetInt("level9cleared", 9);
                SceneManager.LoadScene("Level10");

            }

        }
        if (m_Scene.name == "Level10")
        {
            gameSlider.value = scoreCounter;
            setlevel9 = false;
            setlevel10 = true;
            if (scoreCounter > 55 && setlevel10)//default 100 score
            {
                
                PlayerPrefs.SetInt("level10cleared", 10);
                SceneManager.LoadScene("Level11");

            }

        }

        if (m_Scene.name == "Level11")
        {
            setlevel10 = false;
            setlevel11 = true;
            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel11)//default score 100
            {
                PlayerPrefs.SetInt("level11cleared", 11);
                SceneManager.LoadScene("Level12");
         
            }
        }

        if (m_Scene.name == "Level12")
        {
            setlevel11 = false;
            setlevel12 = true;
            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel12)//default score 100
            {
                PlayerPrefs.SetInt("level12cleared", 2);
                SceneManager.LoadScene("Level13");
              

            }
        }

        if (m_Scene.name == "Level13")
        {
            
            setlevel12 = false;
            setlevel13 = true;
            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel12)//default score 100
            {
                PlayerPrefs.SetInt("level13cleared", 2);
                SceneManager.LoadScene("Level14");

            }
        }

        if (m_Scene.name == "Level14")
        {
            setlevel13 = false;
            setlevel14 = true;
            
            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel14)//default score 100
            {
                PlayerPrefs.SetInt("level14cleared", 14);
                SceneManager.LoadScene("Level15");
                // Destroy(level2obj1);
                // Destroy(level2obj2);


            }
        }

        if (m_Scene.name == "Level15")
        {
            setlevel14 = false;
            setlevel15 = true;

            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel15)//default score 60
            { 
                PlayerPrefs.SetInt("level15cleared", 15);
                SceneManager.LoadScene("Level16");
               


            }
        }
        if (m_Scene.name == "Level16")
        {
            setlevel15 = false;
            setlevel16 = true;

            gameSlider.value = scoreCounter;
            if (scoreCounter > 10 && setlevel15)//default score 35
            { 
                PlayerPrefs.SetInt("level16cleared", 16);
                SceneManager.LoadScene("Level17");



            }
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

    public void loadDefaultscene()
    {
        SceneManager.LoadScene(m_Scene.name);
    }

    public int scoreCouunter()
    {
        return scoreCounter;
    }


  
}
