using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_bullet : MonoBehaviour {
    Vector3 myposition;
    public GameObject target;
    public float bullet_speed = 0f;
    public static float size = 2f;
    public int ysize = 1;
    public int how;
    Vector3 Dir;
    // Use this for initialization
    void Start () {
        int ran = Random.Range(-10, 10);
        myposition = transform.position;
        if (myposition.y > 0)
            ysize = -1;
        else
            ysize = 1;
        if (how == 1)
            Dir = (new Vector3(myposition.x + ran/5f, myposition.y + ysize, myposition.z) - myposition).normalized;
        else if(how == 2)
            Dir = (new Vector3(myposition.x - 2, myposition.y + ysize, myposition.z) - myposition).normalized;
        else if(how == 3)
            Dir = (new Vector3(myposition.x, myposition.y + ysize, myposition.z) - myposition).normalized;
        else if (how == 4)
            Dir = (new Vector3(myposition.x + size, myposition.y + ysize, myposition.z) - myposition).normalized;
        else if (how == 5)
            Dir = (target.transform.position - myposition).normalized;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position += Dir * Time.deltaTime*bullet_speed;
	}
}
