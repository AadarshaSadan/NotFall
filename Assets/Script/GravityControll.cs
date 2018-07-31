using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControll : MonoBehaviour {
   public GameObject gravityobject;
    Rigidbody Rigid_object;
    public float gravityScale = 0.8f;
    public static float globalGravity = -9.81f;
    // Use this for initialization
    void Start() {
        AllcomponentStatue();

    }
	// Update is called once per Rigiframe
	void Update () {


       
       if (Input.GetMouseButtonDown(0))
        {
            AllcomponentStatue();
        }
        if(Input.GetMouseButtonUp(1))
        {
            //AllcomponentMove();
            AllcomponentStatue();
        }

    }
    private void Statue(Rigidbody abc)
    {
        abc.useGravity = false;
        abc.isKinematic = true;
        
    }

    private void Move(Rigidbody abc)
    {
        //abc.useGravity = true;
        //abc.isKinematic = false;
    }

    private void AllcomponentStatue()
    {
            Transform[] allChildren = GetComponentsInChildren<Transform>();


            foreach (Transform child in transform)
            {
                //Debug.Log(transform.GetChild.);
                // Debug.Log(transform.GetChild(transform).name);
                foreach (Transform t in child)
                {
                    Statue(t.GetComponent<Rigidbody>());
                }
            }

            //Statue(Rigid_object);
    }

    private void AllcomponentMove()
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();


        foreach (Transform child in transform)
        {
            //Debug.Log(transform.GetChild.);
            // Debug.Log(transform.GetChild(transform).name);
            foreach (Transform t in child)
            {
                Move(t.GetComponent<Rigidbody>());
            }
        }
    }





}

