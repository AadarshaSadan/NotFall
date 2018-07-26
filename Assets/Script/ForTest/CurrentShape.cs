using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentShape : MonoBehaviour
{
    public Material startingMaterial;
    public Material hoveredMaterial;

	// Use this for initialization
	void Start ()
    {
        ResetMaterialColor();

    }
	
	public void ChangeMaterialColr()
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.GetComponent<Renderer>().material = hoveredMaterial;
    }
    public void ResetMaterialColor()
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.GetComponent<Renderer>().material = startingMaterial;
    }
}
