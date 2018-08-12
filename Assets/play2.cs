using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play2 : MonoBehaviour {
    public int S_core;
    public int temporary=5;
    public GameObject ScoreObjj;
    public Text scoretext;
    // Use this for initialization
    void Start () {
       
	}
    private void OnEnable()
    {
        //S_core = temporary;
    }

    // Update is called once per frame
    void Update () {
        //S_core = ScoreObjj.GetComponent<ScoreManager>().scoreCounter;

        //  Play1txt.text=
        scoretext.text = S_core.ToString();
    }


    public void AddScore(int num)
    {
        S_core += num;
    }

}
