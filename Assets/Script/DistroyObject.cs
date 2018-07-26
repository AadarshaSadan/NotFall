using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
                BoxCollider bt = hit.collider as BoxCollider;
                if (bt != null)
                {
                    Destroy(bt.gameObject);
                }
            }
        }
	}


    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}
