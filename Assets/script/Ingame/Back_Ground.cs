using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Ground : MonoBehaviour {
    public float end = 0f;
    private new Renderer renderer;
    public static float scrollSpeed = 1f;
    public float offset = 0f;
       
    // Use this for initialization
    void Start () {
        renderer = GetComponent<Renderer>();       
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //offset = Time.time*scrollSpeed;
        if (offset <= end)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                offset += 0.3f * Time.deltaTime * scrollSpeed;
                renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            }
        }

        if (offset >= 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                offset -= 0.3f * Time.deltaTime * scrollSpeed;
                renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

            }
        }
        
       

    }
}
