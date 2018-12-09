using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    public GameObject Page;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void YES_Click()
    {
        Global.pg_use = false;
        Application.Quit();
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }

    public void NO_Click() {
        Page.SetActive(false);
        Global.pg_use = false;
    }
}
