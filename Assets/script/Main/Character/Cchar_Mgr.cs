using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cchar_Mgr : MonoBehaviour {
    public static List<Ccharacter> ch = new List<Ccharacter>();
    public Text[] texts;
    
    static int i = 0;
	// Use this for initialization
	void Awake () {
        ChangeCH.a = 1;
        List<Dictionary<string, object>> charData = CSVReader.Read("CSV/char1csv");//캐릭터CSV 데이터를 charData 에 넣어준다           
        for(;i<3;i++)
        {
            Ccharacter c = new Ccharacter();
            c.ch_id = (int)charData[i]["ch_id"];
            c.ch_name = (string)charData[i]["ch_name"];
            c.ch_shop = (int)charData[i]["ch_shop"];
            c.ch_sh = (int)charData[i]["ch_sh"];
            c.ch_speed = (int)charData[i]["ch_speed"];
            c.ch_hp = (int)charData[i]["ch_hp"];
            c.ch_spu = (int)charData[i]["ch_spu"];
            c.ch_price = (int)charData[i]["ch_price"];
            c.ch_txt = (string)charData[i]["ch_txt"];
            c.ch_image = Resources.Load<Sprite>("CH/CH_" + i);
            ch.Add(c);
        }
        
    }

     void Start()
    {
       texts = GetComponent<Text[]>();        
    }


    // Update is called once per frame
    void Update () {
        if(ch[0].ch_use==true)
        {
           texts[0].text = "name:" + ch[2].ch_name;
            texts[1].text = "Speed:" + ch[2].ch_speed.ToString();
            texts[2].text = "Hp:" + ch[2].ch_hp.ToString();
            texts[3].text = "설명:"+ch[2].ch_txt;
        }
        else if(ch[1].ch_use == true)
        {
            texts[0].text = "name:"+ch[1].ch_name;
            texts[1].text = "Speed:"+ch[1].ch_speed.ToString();
            texts[2].text = "Hp:"+ch[1].ch_hp.ToString();
            texts[3].text = "설명:"+ch[1].ch_txt;
        }
       else if (ch[2].ch_use == true)
        {
            texts[0].text = "name:" + ch[0].ch_name;
            texts[1].text = "Speed:" + ch[0].ch_speed.ToString();
            texts[2].text = "Hp:" + ch[0].ch_hp.ToString();
            texts[3].text = "설명:"+ch[0].ch_txt;
        }

    }
    
}
