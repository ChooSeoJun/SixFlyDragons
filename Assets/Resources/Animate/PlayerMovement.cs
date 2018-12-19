using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movePower = 1f;

    Animator animator;
    Vector3 movement;

	// Use this for initialization
	void Start () {
        
        animator = gameObject.GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetBool("isMovinag", false);
            animator.SetInteger("Direction", 0);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetInteger("Direction", -1); // 좌측
            animator.SetBool("isMovinag", true);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetInteger("Direction", 1); // 우측
            animator.SetBool("isMovinag", true);
        }
	}
    void FixedUpdate ()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;

    //      transform.localScale = new Vector3(-1, 1, 1);
        }


        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;

      //      transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}
