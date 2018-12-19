using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Bullet : MonoBehaviour {
    public GameObject create_position;
    public GameObject Bullet;
    public GameObject target;
    Rigidbody rigidbody;
    public bool check = true;
    
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(CreateBullet());
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    IEnumerator CreateBullet()
    {
        while (true) { 
        Instantiate(Bullet, create_position.transform.position, Quaternion.identity);   
            yield return new WaitForSeconds(1f);
            if (shot_bullet.size >= 2)
                check = true;
            else if (shot_bullet.size <= -2)
                check = false;
            if (check == true)
                shot_bullet.size -= 0.4f;
            else
                shot_bullet.size += 0.4f;
     }
    }
}
