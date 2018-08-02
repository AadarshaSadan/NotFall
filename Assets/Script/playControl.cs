using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playControl : MonoBehaviour {
    public Text playercount;
    public bool singleplayer;
    public bool twoplayer;
    private int numberofplayer;
    public GameObject offtimerforsingle;
    // Use this for initialization
    void Start () {
        numberofplayer = PlayerPrefs.GetInt("numberofplayer");
        AddPlayer(numberofplayer);
        if(numberofplayer==2)
        {
            twoplayer = true;
            singleplayer = false;
        }
        else
        {
            singleplayer = true;
            twoplayer = false;
            offtimerforsingle.SetActive(false);

        }
     

    }
	
	// Update is called once per frame
	void Update () {
     
    }
    public void AddPlayer(int number)
    {
      playercount.text = number.ToString();
    }
}
