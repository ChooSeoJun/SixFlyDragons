using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowEQ : MonoBehaviour {
    public GameObject Helmet; // 장착된 Helmet의 이미지
    public GameObject Armor; // 장착된 Armor의 이미지
    public GameObject Shoes; // 장착된 Shoes의 이미지
    public static float maxValue = 0;
    public static float money_up = 0;
    public static float exp_up = 0;
    public static float nd_up = 0;
    public static float hp_down = 20f;
    void Awake () {
        foreach (CChar_EQ e in CChar_EQ_Mgr.eq)
        {
            if (e.index >= 1 && e.index <= 4) // Helmet
            {
                if (e.use == true) // 만약 장비의 use가 true이면 그 장비의 이미지로 변경해준다
                {
                    Helmet.gameObject.GetComponent<Image>().sprite = e.image;
                    if (e.speed > 0)
                        Move.Speed += e.speed / 100f * 8;
                    else if (e.hp > 0)
                        maxValue += e.hp;
                    else if (e.money > 0)
                        money_up += e.money;
                    else if (e.exp > 0)
                        exp_up += e.exp;
                    else if (e.nd > 0)
                        nd_up += e.nd;
                    else if (e.def > 0)
                        hp_down -= e.def / 10f;
                }
            }
            else if (e.index >= 5 && e.index <= 8) // Armor
            {
                if (e.use == true)
                {

                    Armor.gameObject.GetComponent<Image>().sprite = e.image;
                    if (e.speed > 0)
                        Move.Speed += e.speed / 100f * 8;
                    else if (e.hp > 0)
                        maxValue += e.hp;
                    else if (e.money > 0)
                        money_up += e.money;
                    else if (e.exp > 0)
                        exp_up += e.exp;
                    else if (e.nd > 0)
                        nd_up += e.nd;
                    else if (e.def > 0)
                        hp_down -= e.def / 10f;
                }
            }
            else if (e.index >= 9 && e.index <= 16) // Shoes
            {
                if (e.use == true)
                {
                    Shoes.gameObject.GetComponent<Image>().sprite = e.image;
                    if (e.speed > 0)
                        Move.Speed += e.speed / 100f * 8;
                    else if (e.hp > 0)
                        maxValue += e.hp;
                    else if (e.money > 0)
                        money_up += e.money;
                    else if (e.exp > 0)
                        exp_up += e.exp;
                    else if (e.nd > 0)
                        nd_up += e.nd;
                    else if (e.def > 0)
                        hp_down -= e.def / 10f;
                }
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
