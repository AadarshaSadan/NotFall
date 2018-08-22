using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twoplayerControl : MonoBehaviour {

    public GameObject tImer;
    public GameObject ScoreObjj;
    public bool playerone;
    public bool playertwo;

    public GameObject player1;

    public GameObject player2;

    public GameObject playercontrol;


    private int allscore;

    public Text playercount;

    public int playeronescore;
    public int playertwoscore;

    private int numberofplayer;
    public bool twoplayergame;
    public int h;
    public int k;
    public int temp=5;
    public int value;

    //
   
	// Use this for initialization
	void Start () {
        h = 1;
        numberofplayer = PlayerPrefs.GetInt("numberofplayer");
        if (numberofplayer == 2)
        {
            twoplayergame = true;
            playercontrol.SetActive(true);
        }

        RandomNumber();
        playeronescore = 0;
        playertwoscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
       // int score = GetCompone;
        if (twoplayergame)
        {
            k = tImer.GetComponent<timer>().s;
            if (k % 2 == 0)
            {
                playertwo = true;
                AddPlayer(2);
                playerone = false;
                player1.SetActive(false);
                player2.SetActive(true);
            }
            else
            {
                playertwo = false;
                playerone = true;
                player1.SetActive(true);
                player2.SetActive(false);
              
                AddPlayer(1);
            }
        }
        allscore = ScoreObjj.GetComponent<ScoreManager>().scoreCounter;
      
        if(playerone)
        {

           // FindObjectOfType<ScoreManager>().scoreCounter = playeronescore;
                 //   playeronescore = allscore;
               
               
            
            
        }
        if(playertwo)
        {


            // FindObjectOfType<ScoreManager>().scoreCounter = playertwoscore;
            // FindObjectOfType<ScoreManager>().scoreCounter = playertwoscore;
           
        }
        

    }

    public void AddPlayer(int number)
    {
        playercount.text = number.ToString();
    }

    
  public void RandomNumber()
    {


        int[] integers = new int[] { 1, 5, 8, 9, 12 };


     int randValue = Random.Range(0, integers.Length);
        value = integers[randValue];
        
    }
}
