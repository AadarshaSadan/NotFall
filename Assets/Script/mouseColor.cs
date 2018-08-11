using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseColor : MonoBehaviour {
    public Material defaultColor;
    //public GameObject Box;
    public GameObject temp;
    public bool game = false;


    MeshRenderer m_Render;
     void Start()
    {
       m_Render= gameObject.GetComponent<MeshRenderer>();
       
    }

  
        void Update()
        {
            
               /* RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
          

            try
            {
                GameObject hitObject = hit.transform.gameObject;
                // if(hitObject)
                   
                    //print(hitObject.name); 
                   colorall(hitObject);
                  //  temp = hitObject;
                   
            }
                 catch (NullReferenceException e)
                  {
                Debug.Log("null refreance");
                
                  }




            //colorall(hitObject);
        }*/
        
       


                    


            
        }
    // Use this for initialization
    private void OnMouseOver()
    {
        //BroadcastMessahe("OnMouseEnter");
        //Box obj = this.transform.parent;
        // Debug.Log();
        try
        {   colorall(transform.gameObject);
            m_Render.material.color = Color.red;
        }catch(Exception)
        {   // print("NegleteErrorinMouseColor72line");

        }
    }

    private void OnMouseExit()
    {
        // m_Render.material.color = de;
        // m_Render.material.color = Color.white;
        resetall(transform.gameObject);
    }

   public void colorall(GameObject gameobj)
    {
       
        for (int i = 0; i < gameobj.transform.childCount; i++)
        {

            gameobj.transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
            //gameobj.transform.GetChild(i).m_render.material.color = Color.white;
       

        }

    }

    public void resetall(GameObject gameobj)
    {
        for (int i = 0; i < gameobj.transform.childCount; i++)
        {

            gameobj.transform.GetChild(i).GetComponent<Renderer>().material.color = defaultColor.color;
            //gameobj.transform.GetChild(i).m_render.material.color = Color.white;
           // Debug.Log(gameobj.transform.GetChild(i).name);

        }

    }
}
