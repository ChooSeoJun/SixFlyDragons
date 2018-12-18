using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public static int Random_Item = 0; // 랜덤 아이템의 상태 체크 
    public static bool Invincibility_Check = false; // 무적상태 체크
    public static bool nd_check = false;
    public static float Speed = 8f;
    public GameObject Skill_motion;
    public Slider HpBar;
    Vector2 MoveVelocity; 
    Rigidbody2D rigid;
    Transform t;
    Vector3 a;
    Vector3 b;
    public GameObject SuperAmor;
    public GameObject Nd_motion;
    public static bool effect = false; // 아이템 박스 충돌 체크
    public GameObject Armor;
    public GameObject Up;
    public GameObject Down;
    public GameObject Small;
    // Use this for initialization
    void Start () {
        t = gameObject.GetComponent<Transform>();
        a = t.localScale / 2;
        b = t.localScale;
        rigid = GetComponent<Rigidbody2D>();
        if (Cchar_Mgr.ch[0].ch_use == true)
        {
            HpBar.maxValue = Cchar_Mgr.ch[0].ch_hp + ShowEQ.maxValue;
            HpBar.value = Cchar_Mgr.ch[0].ch_hp + ShowEQ.maxValue;
        }
        else if (Cchar_Mgr.ch[1].ch_use == true)
        {
            HpBar.maxValue = Cchar_Mgr.ch[1].ch_hp + ShowEQ.maxValue;
            HpBar.value = Cchar_Mgr.ch[1].ch_hp + ShowEQ.maxValue;
        }
        else if (Cchar_Mgr.ch[2].ch_use == true)
        {
            HpBar.maxValue = Cchar_Mgr.ch[2].ch_hp;
            HpBar.value = Cchar_Mgr.ch[2].ch_hp;
        }
    }	
	// Update is called once per frame
	void Update () {
        Ch_Move();
        Limit();
        if(Random_Item != 0) // 랜덤 아이템 체크
        {
            switch (Random_Item)
            {
                case 1:
                    StartCoroutine(Invincibility());
                    break;
                case 2:
                    StartCoroutine(Hp_up());
                    break;
                case 3:
                    StartCoroutine(Speed_up());
                    break;
                case 4:
                    StartCoroutine(Speed_down());
                    break;
                case 5:
                    StartCoroutine(Size_up());
                    break;
                default:
                    break;
            }
        }
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
        pos.x = Mathf.Clamp(transform.position.x, -8.36f,10000);
        pos.y = Mathf.Clamp(transform.position.y, -4, 2);

        transform.position = new Vector3(pos.x,pos.y,transform.position.z);

    }

    void OnTriggerEnter2D(Collider2D collision) // 부딪혔을때 이벤트
    {
        if(collision.gameObject.tag == "Random") // 랜덤박스에 부딪힘
        {
            effect = true;
            int ran = Random.Range(1, 6);
            Random_Item = ran;
            Destroy(collision.gameObject);
        }
        else if (Invincibility_Check == false)
        {
            if (ShowEQ.nd_up > 0)
            {
                int ran = Random.Range(1, 10);
                if (ran == 3)
                {
                    nd_check = true;
                    Destroy(collision.transform.parent.gameObject);
                }
                else if (collision.gameObject.tag == "FX")
                {
                    if (Skill.skill_check == true)
                    {
                        Skill_motion.SetActive(false);
                        Destroy(collision.transform.parent.gameObject);
                        Skill.skill_check = false;
                    }
                    else
                    {
                        HpBar.value -= ShowEQ.hp_down;
                        Destroy(collision.transform.parent.gameObject);
                    }
                }
            }
            else if (collision.gameObject.tag == "FX")
            {
                if (Skill.skill_check == true)
                {
                    Skill_motion.SetActive(false);
                    Destroy(collision.transform.parent.gameObject);
                    Skill.skill_check = false;
                }
                else
                {
                    HpBar.value -= ShowEQ.hp_down;
                    Destroy(collision.transform.parent.gameObject);
                }
            }
        }
    }

    IEnumerator Invincibility() // 무적 이벤트
    {
        Random_Item = 0;
        Invincibility_Check = true;
        Armor.SetActive(true);
        SuperAmor.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Invincibility_Check = false;
        Armor.SetActive(false);
        SuperAmor.SetActive(false);
        yield return null;
    }

    IEnumerator Hp_up() // 체력 회복
    {
        Random_Item = 0;
        HpBar.value += 20;
        yield return null;
    }

    IEnumerator Speed_up() // 스피드 업
    {
        Random_Item = 0;
        Speed = 12;
        Up.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Speed = 8;
        Up.SetActive(false);
        yield return null;
    }

    IEnumerator Speed_down() // 스피드 다운
    {
        Random_Item = 0;
        Speed = 5;
        Down.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        Speed = 8;
        Down.SetActive(false);
        yield return null;
    }

    IEnumerator Size_up() // 사이즈 감소
    {
        Random_Item = 0;
        t.localScale = a;
        Small.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        t.localScale = b;
        Small.SetActive(false);
        yield return null;
    }
}
