using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_CTR : MonoBehaviour {
    void Start()
    {
    }
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z); 
        Limit();
    }
    void Limit()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Mathf.Clamp(transform.position.x, 1, 412);

        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

    }
}
