using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Mgr : MonoBehaviour {
    public static List<Level> lv = new List<Level>(); // 레벨 리스트
    static int i = 0;

    // Use this for initialization
    void Awake()
    {
        List<Dictionary<string, object>> lvData = CSVReader.Read("CSV/Level"); // CSV를 읽어옴

        for (; i < 50; i++) // CSV값을 lv 리스트에 저장
        {
            Level l = new Level();
            l.level = (int)lvData[i]["Level"];
            l.level_value = (int)lvData[i]["Level_Value"];


            lv.Add(l); // i번째 줄에서 읽어들인 값을 lv에 추가
        }
    }
}
