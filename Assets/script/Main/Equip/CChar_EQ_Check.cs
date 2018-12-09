using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CChar_EQ_Check : MonoBehaviour {

    public GameObject Helmet; // 장착된 Helmet의 이미지
    public GameObject Armor; // 장착된 Armor의 이미지
    public GameObject Shoes; // 장착된 Shoes의 이미지
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (CChar_EQ e in CChar_EQ_Mgr.eq)
        {
            if(e.index >= 1 && e.index <= 4) // Helmet
            {
                if (e.use == true) // 만약 장비의 use가 true이면 그 장비의 이미지로 변경해준다
                {
                    Helmet.gameObject.GetComponent<Image>().sprite = e.image;
                }
            }
            if(e.index >= 5 && e.index <= 8) // Armor
            {
                if (e.use == true)
                {
                    
                    Armor.gameObject.GetComponent<Image>().sprite = e.image;
                }
            }
            if(e.index >= 9 && e.index <= 16) // Shoes
            {
                if (e.use == true)
                {
                    Shoes.gameObject.GetComponent<Image>().sprite = e.image;
                }
            }

        }
	}
    public void HelmetClick() // 장착된 Helmet을 클릭했을때
    {
        for (int i = 0; i < 4; i++)
            CChar_EQ_Mgr.eq[i].use = false; // 모든 Helmet false로 초기화 해준다
        Helmet.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("EQ/EQ"); // 장비가 없는 이미지로 변경해준다
    }
    public void ArmorClick() // 장착된 Armor를 클릭했을때
    {
        for (int i = 4; i < 8; i++)
            CChar_EQ_Mgr.eq[i].use = false;
        Armor.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("EQ/EQ");
    }
    public void ShoesClick() // 장착된 Shoes를 클릭했을때
    {
        for (int i = 8; i < 16; i++)
            CChar_EQ_Mgr.eq[i].use = false;
        Shoes.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("EQ/EQ");
    }
}
