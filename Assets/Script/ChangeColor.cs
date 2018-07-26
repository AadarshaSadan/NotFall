using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject selectedObject;
    public Material L1;
    public Material UpperL;
    public Material Basecolor;

    private void Start()
    {
       
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject getObject = hit.transform.parent.gameObject;
            SelectObject(getObject);

        }
    }


    private void Colorfill(Renderer renObj)
    {
        // Debug.Log(renObj);
        renObj.GetComponent<Renderer>().material.color =Color.white;
       
    }




    
     private void clearColor(GameObject objectRef)
    {

        if ((selectedObject == null))
            return;

        Renderer[] rs = selectedObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {

            // Debug.Log(r.name);
             Material m = r.material;
            m.color = Color.white;
             r.material =Dcolor(objectRef);
        }


        selectedObject = null;
    }

    private void SelectObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
                return;

            clearColor(obj);
        }

        selectedObject = obj;
        print(obj.name);
        Renderer[] rs = obj.GetComponentsInChildren<Renderer>();
        foreach (Renderer t in rs)
        {
            Colorfill(t.GetComponent<Renderer>());
        }

    }
    private Material Dcolor(GameObject rFoBJ)
    {
        if (rFoBJ.tag == "Chair")
            return L1;
        if (rFoBJ.tag == "upperL")
            return UpperL;
        if (rFoBJ.tag == "Basee")
            return Basecolor;
        return Basecolor;



    }
   

}
