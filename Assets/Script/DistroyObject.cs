using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyObject : MonoBehaviour {
    private float doubleClickTime = 1.0f;
    private float lastClickTime = -10f;
   
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            float timeDelta = Time.time - lastClickTime;

            if (timeDelta < doubleClickTime)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {

                    GameObject hitObject = hit.transform.gameObject;
                    // Debug.Log("hitobject =" + hitObject);
                    //Debug.Log(hitObject.tag);
                    //Debug.Log(hitObject.transform.parent);
                    if (hitObject.transform.parent.name != "MainBase" && hitObject.transform.parent.name != "TowerTop")
                    {
                        Destroy(hitObject);
                        FindObjectOfType<ScoreManager>().AddScore(5);

                    }
                   

                }
                




                lastClickTime = 0;
            }
            else
            {
                lastClickTime = Time.time;
               
            }
        }
       
    }
  

    void DestroyGameObject()
    {
        Destroy(gameObject);
       
    }



}
