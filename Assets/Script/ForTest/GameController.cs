using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Material a;
    //public Material b;
    private float doubleClickTime = 1.0f;
    private float lastClickTime = -10f;
    private Renderer rnd;
    // Use this for initialization
    void Start()
    {
        rnd = GetComponent<Renderer>();
        rnd.material = a;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float timeDelta = Time.time - lastClickTime;

            if (timeDelta < doubleClickTime)
            {
               Debug.Log("double click");
                lastClickTime = 0;
            }
            else
            {
                lastClickTime = Time.time;
            }
        }
    }

    private void OnMouseEnter()
    {
        ColorAll(transform.parent.gameObject);
    }

    private void OnMouseExit()
    {
        ResetAll(transform.parent.gameObject);
    }

    void ColorAll(GameObject g)
    {
        for (int i = 0; i < g.transform.childCount; i++)
        {
            g.transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
        }
    }

    void ResetAll(GameObject g)
    {
        for (int i = 0; i < g.transform.childCount; i++)
        {
            g.transform.GetChild(i).GetComponent<Renderer>().material = a;
        }
    }


}
