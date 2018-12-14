using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataLoader : MonoBehaviour {

    public Text[] texts;


    // Use this for initialization
    void Start()
    {
        Global.pg = 1;
        texts = GetComponent<Text[]>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Cchar_Mgr.ch[0].ch_use == true)
        {
            //texts[0].text = "name:" + Cchar_Mgr.ch[2].ch_name;
            texts[1].text =Cchar_Mgr.ch[2].ch_speed.ToString();
            texts[2].text =Cchar_Mgr.ch[2].ch_hp.ToString();
            texts[3].text = Cchar_Mgr.ch[2].ch_txt;
        }
        else if (Cchar_Mgr.ch[1].ch_use == true)
        {
            //texts[0].text = "name:" + Cchar_Mgr.ch[1].ch_name;
            texts[1].text =Cchar_Mgr.ch[1].ch_speed.ToString();
            texts[2].text =Cchar_Mgr.ch[1].ch_hp.ToString();
            texts[3].text =  Cchar_Mgr.ch[1].ch_txt;
        }
        else if (Cchar_Mgr.ch[2].ch_use == true)
        {
            //texts[0].text = "name:" + Cchar_Mgr.ch[0].ch_name;
            texts[1].text =  Cchar_Mgr.ch[0].ch_speed.ToString();
            texts[2].text = Cchar_Mgr.ch[0].ch_hp.ToString();
            texts[3].text = Cchar_Mgr.ch[0].ch_txt;
        }

    }
}
