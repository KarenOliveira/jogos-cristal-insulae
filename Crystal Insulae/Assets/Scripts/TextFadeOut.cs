using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeOut : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (text.color.a >= 0.1f)
        {
            text.color = Color.Lerp(text.color, Color.clear, 0.5f * Time.deltaTime);
        }
        if(text.color.a < 0.1f)
        {
            Debug.Log("Sumiu");
        }
    }
}
