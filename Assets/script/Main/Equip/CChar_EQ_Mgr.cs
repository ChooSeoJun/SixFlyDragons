using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CChar_EQ_Mgr : MonoBehaviour {
    public static List<CChar_EQ> eq = new List<CChar_EQ>(); // 장비 리스트
    static int i = 0;

    // Use this for initialization
    void Awake()
    {
        List<Dictionary<string, object>> eqData = CSVReader.Read("CSV/NarshaProject"); // CSV를 읽어옴

        for (; i < 16; i++) // CSV값을 eq 리스트에 저장
        {
            CChar_EQ e = new CChar_EQ();
            e.index = (int)eqData[i]["eq_index"];
            e.id = (int)eqData[i]["eq_id"];
            e.name = (string)eqData[i]["eq_name"];
            e.sort = (string)eqData[i]["eq_sort"];
            //e.shop = (bool)eqData[i]["eq_shop"];
            e.part = (int)eqData[i]["eq_part"];
            //e.price = (int)eqData[i]["eq_price"];
            e.speed = (float)eqData[i]["eq_speed"];
            e.hp = (float)eqData[i]["eq_hp"];
            e.money = (int)eqData[i]["eq_money"];
            e.exp = (int)eqData[i]["eq_exp"];
            e.nd = (float)eqData[i]["eq_nd"];
            e.def = (int)eqData[i]["eq_def"];
            e.txt = (string)eqData[i]["eq_txt"];

            e.image = Resources.Load<Sprite>("EQ/EQ_" + i);


            eq.Add(e); // i번째 줄에서 읽어들인 값을 eq에 추가
        }
    }
}
