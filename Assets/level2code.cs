using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level2code : MonoBehaviour {
    private int selectlevel;
    public Slider gameslider;

	// Use this for initialization
	void Start () {
        selectlevel = PlayerPrefs.GetInt("movetolevel2");
        Debug.Log("move2 " + selectlevel);
        gameslider.value = 2;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
