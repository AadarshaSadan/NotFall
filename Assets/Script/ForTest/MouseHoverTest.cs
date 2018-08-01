using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverTest : MonoBehaviour {

    public Material a;
    //public Material b;

    private Renderer rnd;
	// Use this for initialization
	void Start () {
        rnd = GetComponent<Renderer>();
        rnd.material = a;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        ColorAll(transform.parent.gameObject);
        Debug.Log("hello");
    }

    private void OnMouseExit()
    {
        ResetAll(transform.parent.gameObject);
    }

    void ColorAll(GameObject g)
    {
        for (int i = 0; i < g.transform.childCount; i++)
        {

            g.transform.GetChild(i).GetComponent<Renderer>().material.color=Color.white;
            Debug.Log(g.transform.GetChild(i).name);
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
