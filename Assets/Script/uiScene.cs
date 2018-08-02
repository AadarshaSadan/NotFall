using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uiScene : MonoBehaviour {
    public int count;
    public GameObject defaulttext;
    public GameObject textone;
    public GameObject texttwo;
    public GameObject exit_object;
   public bool activeg=false;
	// Use this for initialization
	void Start () {
        //defaulttext.GetComponent<>
        defaulttext.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Gamescene()
    {
        if ((GetComponent<Selectplayer>().Single_player))
            {
            PlayerPrefs.SetInt("numberofplayer", 1);
            SceneManager.LoadScene("Game");
           }
        if ((GetComponent<Selectplayer>().Two_player))
        {
            PlayerPrefs.SetInt("numberofplayer", 2);
            SceneManager.LoadScene("Game");
        }
     
           
        
    }

    public void Right_shift()
    {
        if (count >= 1 && count <= 3)
        {
            switch (count)
            {
                case 1:
                    defaulttext.SetActive(false);
                    textone.SetActive(true);
                    texttwo.SetActive(false);
                    GetComponent<Selectplayer>().Single_player = true;
                    GetComponent<Selectplayer>().Two_player = false;
                    exit_object.SetActive(false);
                    activeg = false;
                    break;
                case 2:
                    defaulttext.SetActive(false);
                    texttwo.SetActive(true);
                    textone.SetActive(false);
                    GetComponent<Selectplayer>().Two_player = true;
                    GetComponent<Selectplayer>().Single_player = false;
                    exit_object.SetActive(false);
                    activeg = false;
                    break;
                case 3:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(true);
                    activeg = true;
                    break;



            }
            count++;
            
            
        }
        else
        {
            count = 1;
           
        }
    }

    public void Left_shift()
    {if (count <= 3 && count>=1)
        {
            switch (count)
            {
                case 1:
                    defaulttext.SetActive(false);
                    textone.SetActive(true);
                    texttwo.SetActive(false);
                    GetComponent<Selectplayer>().Single_player = true;
                    GetComponent<Selectplayer>().Two_player = false;
                    exit_object.SetActive(false);
                    activeg = false;
                    break;
                case 2:
                    defaulttext.SetActive(false);
                    texttwo.SetActive(true);
                    textone.SetActive(false);
                    GetComponent<Selectplayer>().Two_player = true;
                    GetComponent<Selectplayer>().Single_player = false;
                    exit_object.SetActive(false);
                    activeg = false;
                    break;
                case 3:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(true);
                    activeg = true;
                    break;
            }
            count--;
            Debug.Log("leftcount" + count);
           
        }
        else
        {
            count = 1;
            
        }
    }

    public void Exitgame()
    {
        
        if(activeg)
        {
           
            Application.Quit();
        }
       
    }
}
