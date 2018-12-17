using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_CTR : MonoBehaviour {
    public GameObject A;
    Transform AT;
    void Start()
    {
        AT = A.transform;
    }
    void Update()
    {
        Limit();
        transform.position = Vector3.Lerp(transform.position, new Vector3 (AT.position.x,0,AT.position.z), 2f * Time.deltaTime);
        transform.Translate(0, 0, -10); //카메라를 원래 z축으로 이동
    }
    void Limit()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Mathf.Clamp(transform.position.x, 1, 412);

        transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

    }
}
