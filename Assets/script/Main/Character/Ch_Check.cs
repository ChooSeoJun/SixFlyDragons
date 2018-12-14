using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_Check : MonoBehaviour {
    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame

    public void Click_1()
    {
        First.SetActive(true);
        Second.SetActive(false);
        Third.SetActive(false);
    }

    public void Click_2()
    {
        First.SetActive(false);
        Second.SetActive(true);
        Third.SetActive(false);
    }

    public void Click_3()
    {
        First.SetActive(false);
        Second.SetActive(false);
        Third.SetActive(true);
    }
}
