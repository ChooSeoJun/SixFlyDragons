﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stage_Update : MonoBehaviour {
    public int stage;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if(stage <= Global.stage)
        {
            gameObject.GetComponent<Image>().color = new Color(255, 255, 255,255);
        }
	}
}
