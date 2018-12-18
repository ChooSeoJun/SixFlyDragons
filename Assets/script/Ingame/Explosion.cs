using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public GameObject particle;
	// Use this for initialization
	void Start () {
        Invoke("Create", 3);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Create()
    {
        Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(particle, 3);
    }
}
