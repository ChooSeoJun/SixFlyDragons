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
        Limit();

    }
     void Ch_Move()
    {
        Vector3 movevelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
            movevelocity = Vector3.left;
        else if (Input.GetAxisRaw("Horizontal") > 0)
            movevelocity = Vector3.right;
        if (Input.GetAxisRaw("Vertical") < 0)
            movevelocity = Vector3.down;             
        else if (Input.GetAxisRaw("Vertical") > 0)
            movevelocity = Vector3.up;

        transform.position += movevelocity * Speed * Time.deltaTime;
        
    }
     void Limit()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Mathf.Clamp(transform.position.x, -5.5f, 5.5f);
        pos.y = Mathf.Clamp(transform.position.y, -3, 0);

        transform.position = pos;

    }
}
