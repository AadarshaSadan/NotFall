using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotate : MonoBehaviour
{
    float velocidade;

   

    // Use this for initialization
    void Start ()
    {
       // transform.Translate(6.35f, 0.9025933f, -7.58f);
    }
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x < Screen.width / 5)
            {
                velocidade += Time.deltaTime * 30f;
            }
            else if (touch.position.x > Screen.width / 5)
            {
                velocidade -= Time.deltaTime * 30f;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocidade += Time.deltaTime*30f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocidade -= Time.deltaTime *30f;
        }

        transform.rotation = Quaternion.Euler(transform.rotation.x, velocidade, transform.rotation.z);

    }
}
