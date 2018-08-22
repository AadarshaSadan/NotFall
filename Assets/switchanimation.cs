using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchanimation : MonoBehaviour {
    public Animator animator;
    public bool onfade;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (onfade)
            fadetolevel();
        if (!onfade)
            onfade = false;
	}
public void fadetolevel()
    {
        animator.SetTrigger("fade_out");
    }
}
