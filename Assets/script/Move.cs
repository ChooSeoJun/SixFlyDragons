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

        transform.position += movevelocity * Speed * Time.deltaTime;
    }
     void Limit()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);

        pos.x = Mathf.Clamp01(pos.x);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }
}
