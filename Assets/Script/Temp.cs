using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {
    public GameObject selectedObject;
    private float doubleClickTime = 1.0f;
    private float lastClickTime = -10f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            float timeDelta = Time.time - lastClickTime;

            if (timeDelta < doubleClickTime)
            {
                Debug.Log("double");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo))
                {
                    GameObject hitObject = hitInfo.transform.parent.gameObject;
                    if (hitObject.tag != "CastleTag")
                        if (hitObject.tag != "mainbase")
                            SelectObject(hitObject);
                }
                else
                {
                    Debug.Log("notDestroy");
                }
                lastClickTime = 0;
            }
            else
            {
                lastClickTime = Time.time;
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
