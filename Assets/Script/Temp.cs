using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour {
    public GameObject selectedObject;
    private float doubleClickTime = 1.0f;
    private float lastClickTime = -10f;
    private Vector3 point;
    public ParticleSystem brust;
   // public int scoreValue = 0;
   // public Text score;
    // Use this for initialization

        
    void Start()
    {
        //score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            float timeDelta = Time.time - lastClickTime;

            if (timeDelta < doubleClickTime)
            {
                Debug.Log("double");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo))
                {
                    GameObject hitObject = hitInfo.transform.parent.gameObject;
                    print(hitObject.tag);
                    if (hitObject.tag != "CastleTag"&& hitObject.name != "MainBase")
                            SelectObject(hitObject);
                }
                else
                {
                    Debug.Log("notDestroy");
                }
                lastClickTime = 0;
            }
            else
            {
                lastClickTime = Time.time;
            }
        }





    }

    void SelectObject(GameObject obj)
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
                return;
        }

        selectedObject = obj;

        for (int i = 0; i < selectedObject.transform.childCount; i++)
        {

            point = selectedObject.transform.GetChild(i).GetComponent<Transform>().position;
            //display burst effect to every cube
            burstDisplay(point);
            // scoreValue += 5;
            //score.text = scoreValue.ToString();
           

        }
        Destroy(selectedObject);
        FindObjectOfType<ScoreManager>().AddScore(5);

    }

    private void burstDisplay(Vector3 Pointget)
    {
        //display in s
        /// print(Pointget);
        brust.transform.position = new Vector3(Pointget.x,Pointget.y,Pointget.z);
        //brust.transform.rotation = new Quaternion();
       // Instantiate(explodedBubble, Pointget.point, Quaternion.identity);
        brust.Play();
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

    }


   
}

