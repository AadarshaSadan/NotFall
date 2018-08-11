using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    Text text;
    float theTime=10;
    public GameObject playerControl;
 

    public bool player2state = false;
    public bool player1state=true;
    
    //public GameObject setplayer;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
      
	}
	
	// Update is called once per frame
	void Update () {
        if (playerControl.GetComponent<playControl>().twoplayer)
        {
            ResetTimer();
           

        }
      
        
	}

    private void ResetTimer()
    {
        
        if (theTime < 0)
        {
            theTime = 10;
        }

        theTime -= Time.deltaTime;    // string seconds = (theTime % 60).ToString("f0");

        text.text = theTime.ToString("f0");
       
    }
}
