using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_bullet : MonoBehaviour {
    Vector3 myposition;
    public GameObject target;
    public float bullet_speed = 0f;
    // Use this for initialization
    void Start () {
        myposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Dir = (target.transform.position - myposition).normalized;
        transform.position += Dir * Time.deltaTime*bullet_speed;
	}
}
