using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collision : MonoBehaviour {
    public GameObject tower;
    public GameObject GameOverText;
  
    private void OnCollisionEnter(Collision collision)
    {
        // print(gameObject.name+"was tiggred is"+collision.gameObject.name);

        //GameOverText.enabled = true;
        GameOverText.SetActive(true);
        Debug.Log("gameover");
     
     
      
    }
 
}
