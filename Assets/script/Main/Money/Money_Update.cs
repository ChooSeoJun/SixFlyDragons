using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money_Update : MonoBehaviour {
    public Text money_text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       money_text.text = Global.money.ToString() + "$";
	}
}
