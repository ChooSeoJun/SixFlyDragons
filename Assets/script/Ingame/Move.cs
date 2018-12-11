using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public float Speed = 0f;
    public Slider HpBar;
    Vector2 MoveVelocity; 
    Rigidbody2D rigid;   
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        if (Cchar_Mgr.ch[0].ch_use == true)
            HpBar.maxValue = Cchar_Mgr.ch[0].ch_hp;
        else if (Cchar_Mgr.ch[1].ch_use == true)
        {
            HpBar.maxValue = Cchar_Mgr.ch[1].ch_hp;
            HpBar.value = Cchar_Mgr.ch[1].ch_hp;
        }
        else if (Cchar_Mgr.ch[2].ch_use == true)
            HpBar.maxValue = Cchar_Mgr.ch[2].ch_hp;
    }	
	// Update is called once per frame
	void Update () {
        Ch_Move();
        Limit();
    }
    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + MoveVelocity * Time.fixedDeltaTime);
    }
    void Ch_Move()
    {
        
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        MoveVelocity = moveInput.normalized * Speed;

    }
     void Limit()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Mathf.Clamp(transform.position.x, -5.5f, 5.5f);
        pos.y = Mathf.Clamp(transform.position.y, -4, -1);

        transform.position = pos;

    }
}
