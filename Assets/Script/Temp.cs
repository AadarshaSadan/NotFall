using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {
    public GameObject selectedObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject hitObject = hitInfo.transform.parent.gameObject;
                if (hitObject.tag != "CastleTag")
                    if(hitObject.tag!="mainbase")
                        SelectObject(hitObject);
            }
            else
            {
                Debug.Log("notDestroy");
            }
        }
    }

    void SelectObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
                return;
        }

        selectedObject = obj;
       Destroy(selectedObject);

    }

   
}
