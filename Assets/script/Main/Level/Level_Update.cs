﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level_Update : MonoBehaviour {
    public Text Level_text;
    public GameObject Level_Show;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Level_text.text = Global.exp.ToString();
        foreach (Level l in Level_Mgr.lv)
        {
            if(l.level == Global.exp)
            {
                if (l.level_value <= Global.exp_value)
                {
                    Global.exp++;
                    Global.exp_value -= l.level_value;
                }
                Level_Show.GetComponent<Image>().fillAmount = (float)Global.exp_value / (float)l.level_value;
            }
        }

    }
}
