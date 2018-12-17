using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    int a = 0;
	// Use this for initialization
	void Start () {
        if (gameObject.transform.position == new Vector3(-8.34f, 6.02f, 0))
            a = 1;
        else StartCoroutine(Bullet_Make());
    }
    void Update()
    {
        if (a == 1)
            transform.position = new Vector3(-8.34f, 6.02f, 0);
    }
    IEnumerator Bullet_Make()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }
}
