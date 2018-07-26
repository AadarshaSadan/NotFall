using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public Transform tempObj;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
       
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo,100f))
        {
            if (hitInfo.collider!=null)
            {
                if (hitInfo.collider.transform.parent.name == "Orange")
                {
                    hitInfo.collider.transform.parent.gameObject.GetComponent<CurrentShape>().ChangeMaterialColr();
                    tempObj = hitInfo.collider.transform;
                    GameObject.Find("Purple").GetComponent<CurrentShape>().ResetMaterialColor();
                }
                else if (hitInfo.collider.transform.parent.name == "Purple")
                {
                    hitInfo.collider.transform.parent.gameObject.GetComponent<CurrentShape>().ChangeMaterialColr();
                    tempObj = hitInfo.collider.transform;
                    GameObject.Find("Orange").GetComponent<CurrentShape>().ResetMaterialColor();
                }


            }
            else 
            {
                Debug.Log("nothing selected");
            }
           
                
           
          
        }
      
    }

   


}
