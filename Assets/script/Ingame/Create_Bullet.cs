using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Bullet : MonoBehaviour {
    public GameObject Bullet;
    public float Bullet_speed = 0f;
    
	// Use this for initialization
	void Start () {
        StartCoroutine(CreateBullet());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator CreateBullet()
    {
        while(true)
        {
            Debug.Log("dd");
            yield return new WaitForSeconds(3);
        }
    }
}
