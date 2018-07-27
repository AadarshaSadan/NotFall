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
                Debug.Log("double");
               
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
