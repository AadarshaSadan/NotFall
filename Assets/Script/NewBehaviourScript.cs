using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject target = null;
    public bool orbitY = false;
    float velocidade;
    float rotatespeed=40f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        velocidade = 0f;

    if (target !=null)
        {
            transform.LookAt(target.transform);
            if (orbitY)
            {

                foreach (Touch touch in Input.touches)
                {
                    if (touch.position.x < Screen.width / 5)
                    {

                        velocidade -= Time.deltaTime * rotatespeed;
                    }
                    else if (touch.position.x > (Screen.width-(Screen.width / 5)))
                    {
            
                        velocidade += Time.deltaTime * rotatespeed;
                    }
                }
                if (Input.GetKey(KeyCode.D))
                {
                    
                    velocidade += Time.deltaTime * rotatespeed;
                }
                if (Input.GetKey(KeyCode.A))
                {

                    velocidade -= Time.deltaTime * rotatespeed;
                }



                transform.RotateAround(target.transform.position, Vector3.up, velocidade);
               


            }
                
        }
	}
}
