using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        if( anim == null )
            Debug.Log("anim == null");
		
	}
	
	// Update is called once per frame
	void Update () {
        float f = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Key Space");
            anim.SetBool("Running", true);
            anim.SetBool("Run", true);
            anim.SetTrigger("Jump");
        }
        else if( Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Running", false);
            anim.SetBool("Run", true);
        }
        


    }
}
