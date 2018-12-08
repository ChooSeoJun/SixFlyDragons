using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Out : MonoBehaviour {
    // Use this for initialization
    Color color;
    SpriteRenderer spr;

    void Start () {
       spr = GetComponent<SpriteRenderer>();
       
	} 
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float f = 1f; f >= -1f; f -= 0.1f)
        {
            color = spr.color;
            color.a = f;
            spr.color = color;
            yield return null;
        }
    }


}
