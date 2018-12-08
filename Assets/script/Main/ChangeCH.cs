using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* 보여주는 캐릭터를 바꾸는 클래스*/
public class ChangeCH : MonoBehaviour {
    public static int a = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(a != 0)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Cchar_Mgr.ch[i].ch_use == true)
                    gameObject.GetComponent<Image>().sprite = Cchar_Mgr.ch[i].ch_image;
            }
        }
    }
}
