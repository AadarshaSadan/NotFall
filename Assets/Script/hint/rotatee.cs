using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatee : MonoBehaviour {
    public GameObject target = null;
    public bool orbitY = false;
    float velocidade;
    float rotatespeed = 40f;
    float moveSpeed = 10f;
    public bool orbitX = false;
    public bool upi = false;
    public bool down = false;

    public GameObject righttouchicon;
    public GameObject leftobject;

    // Update is called once per frame

    private void Start()
    {
      
        StartCoroutine(WaitBeforeLoding());
       
    }

   

    IEnumerator WaitBeforeLoding()
    {
        yield return new WaitForSeconds(1f);
        righttouchicon.SetActive(true);
        yield return new WaitForSeconds(1f);
        orbitY = true;
        yield return new WaitForSeconds(2f);
        righttouchicon.SetActive(false);
        yield return new WaitForSeconds(3f);
        orbitY = false;

        yield return new WaitForSeconds(1f);
        leftobject.SetActive(true);
        yield return new WaitForSeconds(1f);
        orbitX = true;
        yield return new WaitForSeconds(2f);
        leftobject.SetActive(false);
        yield return new WaitForSeconds(3f);
        orbitX = false;

        upi = true;
        yield return new WaitForSeconds(1f);
        upi = false;

        down = true;
        yield return new WaitForSeconds(1f);
        down = false;
        //orbitX = true;
        yield return new WaitForSeconds(2f);
        
        //leftobject.SetActive(false);
        //yield return new WaitForSeconds(3f);
        //orbitX = false;
    }

    void Update()
    {
        velocidade = 0f;
        // if (transform.position.y > 5 && transform.position.y < 25)

        if (target != null)
        {
            // transform.LookAt(target.transform);
            if (orbitY)
            {
                velocidade += Time.deltaTime * rotatespeed;
                Debug.Log(velocidade);
            }

            if (orbitX)
            {
                velocidade -= Time.deltaTime * rotatespeed;
                
            }  
            if(upi)
            {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            }

            if (down)
            {
                transform.position += -Vector3.up * moveSpeed * Time.deltaTime;
            }
                   



                transform.RotateAround(target.transform.position, Vector3.up, velocidade);



            

        }

    }
}

