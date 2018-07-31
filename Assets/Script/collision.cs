using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class collision : MonoBehaviour {
    public GameObject tower;
    public GameObject clickevent;
    public GameObject rotate;
    public GameObject toptext;
    public GameObject score_all;
    public GameObject levelslider;
    public Text fromscoremanager;


    private void Start()
    {
        clickevent.GetComponent<Temp>();
        rotate.GetComponent<ObjRotate>();
        //toptext.GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(gameObject.name + "was tiggred is" + collision.gameObject.tag);
        //Debug.Log("gameover");
        if (collision.gameObject.tag == "mainbase")
        {
            Debug.Log("hey game is over");
            //
            stopallComponent();
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            //
        }
     
     
      
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tiggred");
    }

   private void stopallComponent()
    {
       
        clickevent.SetActive(false);
        toptext.SetActive(false);
        score_all.SetActive(true);
        levelslider.SetActive(false);

        //rotate.SetActive(false);
    }
public void AddScoretext(int number)
    {
        fromscoremanager.text = number.ToString();
    }
}
