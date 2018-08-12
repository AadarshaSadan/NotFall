using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play1 : MonoBehaviour
{
    public Text scoretext;
    public int S_core=0;
    public GameObject ScoreObjj;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoretext.text = S_core.ToString();
	}

    private void OnEnable()
    {
      
    }


    public void AddScore(int num)
    {
        S_core += num;
    }
}
