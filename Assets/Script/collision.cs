using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class collision : MonoBehaviour {
    public GameObject tower;
    public GameObject rotate;
    public GameObject toptext;
    public GameObject score_all;
    public GameObject levelslider;
    public GameObject playerandtime;
    public AudioSource mainsound;
    
    public Text fromscoremanager;
    private void Update()
    {
       if(transform.position.y<8)
        {
            stopallComponent();
        }
    }

    private void Start()
    {}

    private void OnCollisionEnter(Collision collision)
    {
        //print(gameObject.name + "was tiggred is" + collision.gameObject.tag);
        //Debug.Log("gameover");
        if (collision.gameObject.tag == "mainbase")
        {
            //Debug.Log("hey game is over");
            //
            stopallComponent();
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            //
        }
     
     
      
    }
 

   private void stopallComponent()
    {
       
        //clickevent.SetActive(false);
        toptext.SetActive(false);
        score_all.SetActive(true);
        levelslider.SetActive(false);
        mainsound.Stop();
        playerandtime.SetActive(false);

        //rotate.SetActive(false);
    }
public void AddScoretext(int number)
    {
        fromscoremanager.text = number.ToString();
    }
}
