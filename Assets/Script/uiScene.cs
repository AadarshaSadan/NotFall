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
        SceneManager.LoadScene("Game");
    }

    public void Right_shift()
    {
       switch(count)
        {
            case 0:
                print("default");
                defaulttext.SetActive(true);
                texttwo.SetActive(false);
                textone.SetActive(false);
                break;
            case 1:
                defaulttext.SetActive(false);
                textone.SetActive(true);
                texttwo.SetActive(false);
                print("playerone");
                

                break;
            case 2:
                defaulttext.SetActive(false);
                texttwo.SetActive(true);
                textone.SetActive(false);
                print("playerTwo");
                break;
            case 3:
                print("exit");
                count = 1;
                break;
            default:
                print("Incorrect intelligence level.");
                defaulttext.SetActive(true);
                count =1;
                break;
        }
        count++;
        Debug.Log(count);
    }

    public void Left_shift()
    {
        switch (count)
        {
            case -1:
                count = 1;
                break;
            case 0:
                print("default");
                defaulttext.SetActive(true);
                texttwo.SetActive(false);
                textone.SetActive(false);
                break;
            case 1:
                defaulttext.SetActive(false);
                textone.SetActive(true);
                texttwo.SetActive(false);
                print("playerone");


                break;
            case 2:
                defaulttext.SetActive(false);
                texttwo.SetActive(true);
                textone.SetActive(false);
                print("playerTwo");
                break;
            case 3:
                print("exit");
                count = 1;
                break;
            default:
                print("Incorrect intelligence level.");
                defaulttext.SetActive(true);
                count = 0;
                break;
        }
        count--;
        Debug.Log("leftcount"+count);
    }
}
