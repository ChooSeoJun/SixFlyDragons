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
            case "군용 목도리":
                for (int i = 0; i < 4; i++) // 모든 Helmet을 false 초기화 해준다
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[0].use = true; // 클릭한 Helmet을 true로 변경해준다
                break;

            case "레몬맛 치료제":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[1].use = true;
                break;
            case "디지털 보물지도":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[2].use = true;
                break;
            case "소형 메모리 칩":
                for (int i = 0; i < 4; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[3].use = true;
                break;
                // Armor
            case "강철 갑옷":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[4].use = true;
                break;
            case "특수 재질 갑옷":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[5].use = true;
                break;
            case "가죽 방탄복":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[6].use = true;
                break;
            case "신식 방탄복":
                for (int i = 4; i < 8; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[7].use = true;
                break;
                // Shoese
            case "근력 강화 부목":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[8].use = true;
                break;
            case "탈착형 부스터":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[9].use = true;
                break;
            case "소형 부스터":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[10].use = true;
                break;
            case "소형 치료상자":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[11].use = true;
                break;
            case "훌륭한 대화수단":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[12].use = true;
                break;
            case "정보 저장 장치 ":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[13].use = true;
                break;
            case "발목 지지대 ":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[14].use = true;
                break;
            case "소형 추진제":
                for (int i = 8; i < 16; i++)
                    CChar_EQ_Mgr.eq[i].use = false;
                CChar_EQ_Mgr.eq[15].use = true;
                break;
            default:
                break;
        }

  

    }
}
