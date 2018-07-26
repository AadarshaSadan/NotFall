using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour {
    Text UpdateHeight;
    public Slider gameSlider;
	// Use this for initialization
	void Start ()
    {
        UpdateHeight = GetComponent<Text>();
    }

    private void Update()
    {
        UpdateHeight.text = gameSlider.value.ToString();
    }
    //gameSlider.Value
}
