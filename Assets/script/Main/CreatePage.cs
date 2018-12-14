using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePage : MonoBehaviour {

    public GameObject Page;
    public int a;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        if(Global.pg_use == false || a == 1)
        { 
            Page.SetActive(true);
            Global.pg_use = true;
        }
    }
}
