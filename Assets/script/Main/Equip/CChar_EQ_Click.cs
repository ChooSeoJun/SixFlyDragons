using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CChar_EQ_Click : MonoBehaviour {

    public void Click() // 장비 버튼을 클릭했을때
    {
        Text[] trSphereList = gameObject.GetComponentsInChildren<Text>();
        switch(trSphereList[2].text) // 아이템의 이름을 이용해서 클릭한 장비가 무엇인지 판단
        {
            // Helmet
            case "A2 type 나노 머신":
                for (int i = 0; i < 4; i++) // 모든 Helmet을 false 초기화 해준다
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[0].use = true; // 클릭한 Helmet을 true로 변경해준다
                break;

            case "H_1형 응고제":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[1].use = true;
                break;
            case "초소형 금속 탐지기":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[2].use = true;
                break;
            case "소형 녹화 카메라":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[3].use = true;
                break;
                // Armor
            case "SPA_4 추진제":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[4].use = true;
                break;
            case "에너지 장갑":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[5].use = true;
                break;
            case "BT_2h 왜곡 방벽":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[6].use = true;
                break;
            case "Anti-Bullet 방호복":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[7].use = true;
                break;
                // Shoese
            case "SP-4 type 외골격":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[8].use = true;
                break;
            case "관성 제어 패널":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[9].use = true;
                break;
            case "T-Drive 추진기":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[10].use = true;
                break;
            case "소형 의료용 구급 상자":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[11].use = true;
                break;
            case "협상가의 협상서":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[12].use = true;
                break;
            case "움직임 기록 패널":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[13].use = true;
                break;
            case "SP-2V type 외골격":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[14].use = true;
                break;
            case "중력 왜곡 패널":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[15].use = true;
                break;
            default:
                break;
        }

  

    }
}
