﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Bullet : MonoBehaviour {
    public GameObject create_position;
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
            Instantiate(Bullet,create_position.transform.position,Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}