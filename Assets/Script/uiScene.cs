using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiScene : MonoBehaviour {
    public int count;
    public GameObject defaulttext;
    public GameObject textone;
    public GameObject texttwo;
    public GameObject Level;
    public GameObject exit_object;
    public bool activeg=false;
    public string id;
	// Use this for initialization
	void Start () {
        //defaulttext.GetComponent<>
        defaulttext.SetActive(true);  
    }
    private void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
    }


    // Update is called once per frame
    void Update () {

        id = GetComponent<levelmanager>().defaultolevel;
        Debug.Log("this is " + id + " got it");
    }
    public void Gamescene()
    {
        if ((GetComponent<Selectplayer>().Single_player))
            {
            PlayerPrefs.SetInt("numberofplayer", 1);
            SceneManager.LoadScene("Level"+id);
           }
        if ((GetComponent<Selectplayer>().Two_player))
        {
            PlayerPrefs.SetInt("numberofplayer", 2);
            SceneManager.LoadScene("Level"+id);
        }
     
           
        
    }

    public void Right_shift()
    {
        if (count >= 1 && count <= 4)
        {
            switch (count)
            {
                case 1:
                    defaulttext.SetActive(false);
                    textone.SetActive(true);
                    texttwo.SetActive(false);
                    GetComponent<Selectplayer>().Single_player = true;
                    GetComponent<Selectplayer>().Two_player = false;
                    Level.SetActive(false);
                    exit_object.SetActive(false);
                    GetComponent<levelmanager>().Panel = false;
                    activeg = false;
                    break;
                case 2:
                    defaulttext.SetActive(false);
                    texttwo.SetActive(true);
                    textone.SetActive(false);
                    GetComponent<Selectplayer>().Two_player = true;
                    GetComponent<Selectplayer>().Single_player = false;
                    exit_object.SetActive(false);
                    Level.SetActive(false);
                    GetComponent<levelmanager>().Panel = false;
                    activeg = false;
                    break;
                case 3:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(true);
                    Level.SetActive(false);
                    activeg = true;
                    GetComponent<levelmanager>().Panel = false;
                    break;
                case 4:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(false);
                    Level.SetActive(true);
                    GetComponent<levelmanager>().Panel = true;
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
    {if (count <= 4 && count>=1)
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
                    Level.SetActive(false);
                    GetComponent<levelmanager>().Panel = false;
                    activeg = false;
                    break;
                case 2:
                    defaulttext.SetActive(false);
                    texttwo.SetActive(true);
                    textone.SetActive(false);
                    GetComponent<Selectplayer>().Two_player = true;
                    GetComponent<Selectplayer>().Single_player = false;
                    exit_object.SetActive(false);
                    Level.SetActive(false);
                    GetComponent<levelmanager>().Panel = false;
                    activeg = false;
                    break;
                case 3:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(true);
                    Level.SetActive(false);
                    GetComponent<levelmanager>().Panel = false;
                    activeg = true;
                    break;
                case 4:
                    textone.SetActive(false);
                    defaulttext.SetActive(false);
                    texttwo.SetActive(false);
                    exit_object.SetActive(false);
                    Level.SetActive(true);
                    GetComponent<levelmanager>().Panel = true;
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
