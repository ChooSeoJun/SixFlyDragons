using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cchar_Mgr : MonoBehaviour {
    public static List<Ccharacter> ch = new List<Ccharacter>();
    
    static int i = 0;
	// Use this for initialization
	void Awake () {
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
    
}
