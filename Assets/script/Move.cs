using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float Speed = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ch_Move();
 
	}
     void Ch_Move()
    {
        Vector3 movevelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
            movevelocity = Vector3.left;
        else if (Input.GetAxisRaw("Horizontal") > 0)
            movevelocity = Vector3.right;

        transform.position += movevelocity * Speed * Time.deltaTime;
        
    }
     void Limit()
    {
        Vector2 pos;
        pos.x = Mathf.Clamp(transform.position.x, -5.5f, 5.5f);

    }
}
