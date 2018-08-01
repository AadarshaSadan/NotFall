using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dis : MonoBehaviour {
    //public GameObject upper;
    public GameObject selectedobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {

            

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {

                GameObject hitObject = hit.transform.gameObject;
                Debug.Log("hitobject ="+hitObject);
                Destroy(hitObject);
                
            }
        }
          

    }
    void SelectObject(GameObject obj)
    {
       
        if (selectedobj != null)
        {
            if (obj == selectedobj)
                return;
        }

        selectedobj = obj;
        Debug.Log(selectedobj);

      

    }


}
