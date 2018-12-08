using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CChar_EQ_Mgr : MonoBehaviour {
    public static List<CChar_EQ> eq = new List<CChar_EQ>(); // 장비 리스트
    public GameObject Helmet; // Helmet 장비
    public GameObject Armor; // Armor 장비
    public GameObject Shoes; // Shoes 장비
    public GameObject Content; 
    GameObject Object;
    public GameObject AllButton; // 전체 버튼
    public GameObject HelmetButton; // 머리 버튼
    public GameObject ArmorButton; // 몸통 버튼
    public GameObject ShoesButton; // 발 버튼
    static int i = 0;

    // Use this for initialization
    void Awake()
    {
        ChangeCH.a = 1;
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

    void Start()
    {
        int j = 0;
        foreach (CChar_EQ e in eq)
        {
            if (e.part == 3)
                Object = Instantiate(Helmet); // part값이 3이라면 Helmet을 생성
            else if (e.part == 1)
                Object = Instantiate(Armor); // part값이 1이라면 Armor를 생성
            else if (e.part == 2)
                Object = Instantiate(Shoes); // part값이 2라면 Shoes를 생성
            Object.transform.SetParent(Content.transform); // 장비를 Content에 종속시킴
            Object.transform.position = new Vector3(1250.385f, 680.8967f - 180 * j, 0); // 장비를 순서대로 정렬하기 위함

            Text[] trSphereList = Object.gameObject.GetComponentsInChildren<Text>();
            Image[] im = Object.gameObject.GetComponentsInChildren<Image>();
            im[1].GetComponent<Image>().sprite = e.image;
            if (e.speed > 0)
                trSphereList[0].text = "능력 : " + e.speed + "% 스피드 증가";
            else if (e.hp > 0)
                trSphereList[0].text = "능력 : " + e.hp + "% hp 증가";
            else if (e.money > 0)
                trSphereList[0].text = "능력 : " + e.money + "% 돈 획득량 증가";
            else if (e.exp > 0)
                trSphereList[0].text = "능력 : " + e.exp + "% 경험치 획득량 증가";
            else if (e.nd > 0)
                trSphereList[0].text = "능력 : " + e.nd + "% 회피";
            else if (e.def > 0)
                trSphereList[0].text = "능력 : " + e.def + "% 방어력 증가";
            trSphereList[1].text = e.txt;
            trSphereList[2].text = e.name;  // 능력과 이름 설명을 표시함
            j++;
        }
    }

    public void AllButtonClick() // 전체 버튼을 클릭했을때 전체 버튼의 위치 조정, 장비들의 정렬
    {
        AllButton.transform.position = new Vector3(AllButton.transform.position.x, 936.4423f, AllButton.transform.position.z);

        HelmetButton.transform.position = new Vector3(HelmetButton.transform.position.x, 869.4424f, HelmetButton.transform.position.z);
        ArmorButton.transform.position = new Vector3(ArmorButton.transform.position.x, 869.4424f, ArmorButton.transform.position.z);
        ShoesButton.transform.position = new Vector3(ShoesButton.transform.position.x, 869.4424f, ShoesButton.transform.position.z); // 위치 조정

        Content.transform.position = new Vector3(1258.11f, -668.4035f, -208.5f);
        RectTransform rt = Content.gameObject.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(860, 2566.6f); // Content 크기 조정
        GameObject[] objects = GameObject.FindGameObjectsWithTag("EQ_Button");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]); // 장비를 모두 삭제 해준다

        int j = 0;
        foreach (CChar_EQ e in eq)
        {
            if (e.part == 3)
                Object = Instantiate(Helmet, new Vector3(), Helmet.transform.rotation);
            else if (e.part == 1)
                Object = Instantiate(Armor, new Vector3(), Armor.transform.rotation);
            else if (e.part == 2)
                Object = Instantiate(Shoes, new Vector3(), Shoes.transform.rotation);
            Object.transform.SetParent(Content.transform);
            Object.transform.position = new Vector3(1250.385f, -748.906f - 180 * j, 0);  // 장비 재정렬
            Text[] trSphereList = Object.gameObject.GetComponentsInChildren<Text>();
            Image[] im = Object.gameObject.GetComponentsInChildren<Image>();
            im[1].GetComponent<Image>().sprite = e.image;
            if (e.speed > 0)
                trSphereList[0].text = "능력 : " + e.speed + "% 스피드 증가";
            else if (e.hp > 0)
                trSphereList[0].text = "능력 : " + e.hp + "% hp 증가";
            else if (e.money > 0)
                trSphereList[0].text = "능력 : " + e.money + "% 돈 획득량 증가";
            else if (e.exp > 0)
                trSphereList[0].text = "능력 : " + e.exp + "% 경험치 획득량 증가";
            else if (e.nd > 0)
                trSphereList[0].text = "능력 : " + e.nd + "% 회피";
            else if (e.def > 0)
                trSphereList[0].text = "능력 : " + e.def + "% 방어력 증가";
            trSphereList[1].text = e.txt;
            trSphereList[2].text = e.name;
            j++;
        }
    }

    public void HelmetButtonClick() // 머리 버튼을 클릭했을때 머리 버튼의 위치 조정, 장비들의 정렬
    {
        HelmetButton.transform.position = new Vector3(HelmetButton.transform.position.x, 936.4423f, HelmetButton.transform.position.z);

        AllButton.transform.position = new Vector3(AllButton.transform.position.x, 869.4424f, AllButton.transform.position.z);
        ArmorButton.transform.position = new Vector3(ArmorButton.transform.position.x, 869.4424f, ArmorButton.transform.position.z);
        ShoesButton.transform.position = new Vector3(ShoesButton.transform.position.x, 869.4424f, ShoesButton.transform.position.z); 

        Content.transform.position = new Vector3(1258.11f, -668.4035f, -208.5f);
        RectTransform rt = Content.gameObject.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(860, 418.1f);
        GameObject[] objects = GameObject.FindGameObjectsWithTag("EQ_Button");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]);
        int j = 0;
        foreach (CChar_EQ e in eq)
        {
            if (e.part == 3)
            {
                Object = Instantiate(Helmet, new Vector3(), Helmet.transform.rotation);
                Object.transform.SetParent(Content.transform);
                Object.transform.position = new Vector3(1250.385f, -748.906f - 180 * j, 0);

                Text[] trSphereList = Object.gameObject.GetComponentsInChildren<Text>();
                Image[] im = Object.gameObject.GetComponentsInChildren<Image>();
                im[1].GetComponent<Image>().sprite = e.image;
                if (e.speed > 0)
                    trSphereList[0].text = "능력 : " + e.speed + "% 스피드 증가";
                else if (e.hp > 0)
                    trSphereList[0].text = "능력 : " + e.hp + "% hp 증가";
                else if (e.money > 0)
                    trSphereList[0].text = "능력 : " + e.money + "% 돈 획득량 증가";
                else if (e.exp > 0)
                    trSphereList[0].text = "능력 : " + e.exp + "% 경험치 획득량 증가";
                else if (e.nd > 0)
                    trSphereList[0].text = "능력 : " + e.nd + "% 회피";
                else if (e.def > 0)
                    trSphereList[0].text = "능력 : " + e.def + "% 방어력 증가";
                trSphereList[1].text = e.txt;
                trSphereList[2].text = e.name;
                j++;
            }
        }
    }

    public void ArmorButtonClick() // 몸통 버튼을 클릭했을때 몸통 버튼의 위치 조정, 장비들의 정렬
    {
        ArmorButton.transform.position = new Vector3(ArmorButton.transform.position.x, 936.4423f, ArmorButton.transform.position.z);

        HelmetButton.transform.position = new Vector3(HelmetButton.transform.position.x, 869.4424f, HelmetButton.transform.position.z);
        AllButton.transform.position = new Vector3(AllButton.transform.position.x, 869.4424f, AllButton.transform.position.z);
        ShoesButton.transform.position = new Vector3(ShoesButton.transform.position.x, 869.4424f, ShoesButton.transform.position.z);

        Content.transform.position = new Vector3(1258.11f, -668.4035f, -208.5f);
        RectTransform rt = Content.gameObject.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(860, 418.1f);
        GameObject[] objects = GameObject.FindGameObjectsWithTag("EQ_Button");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]);
        int j = 0;
        foreach (CChar_EQ e in eq)
        {
            if (e.part == 1)
            {
                Object = Instantiate(Armor, new Vector3(), Armor.transform.rotation);

                Object.transform.SetParent(Content.transform);
                Object.transform.position = new Vector3(1250.385f, -748.906f - 180 * j, 0);

                Text[] trSphereList = Object.gameObject.GetComponentsInChildren<Text>();
                Image[] im = Object.gameObject.GetComponentsInChildren<Image>();
                im[1].GetComponent<Image>().sprite = e.image;
                if (e.speed > 0)
                    trSphereList[0].text = "능력 : " + e.speed + "% 스피드 증가";
                else if (e.hp > 0)
                    trSphereList[0].text = "능력 : " + e.hp + "% hp 증가";
                else if (e.money > 0)
                    trSphereList[0].text = "능력 : " + e.money + "% 돈 획득량 증가";
                else if (e.exp > 0)
                    trSphereList[0].text = "능력 : " + e.exp + "% 경험치 획득량 증가";
                else if (e.nd > 0)
                    trSphereList[0].text = "능력 : " + e.nd + "% 회피";
                else if (e.def > 0)
                    trSphereList[0].text = "능력 : " + e.def + "% 방어력 증가";
                trSphereList[1].text = e.txt;
                trSphereList[2].text = e.name;
                j++; 
            }
        }
    }

    public void ShoesButtonClick() // 신발 버튼을 클릭했을때 신발 버튼의 위치 조정, 장비들의 정렬
    {
        ShoesButton.transform.position = new Vector3(ShoesButton.transform.position.x, 936.4423f, ShoesButton.transform.position.z);

        AllButton.transform.position = new Vector3(AllButton.transform.position.x, 869.4424f, AllButton.transform.position.z);
        HelmetButton.transform.position = new Vector3(HelmetButton.transform.position.x, 869.4424f, HelmetButton.transform.position.z);
        ArmorButton.transform.position = new Vector3(ArmorButton.transform.position.x, 869.4424f, ArmorButton.transform.position.z);

        Content.transform.position = new Vector3(1258.11f, -668.4035f, -208.5f);
        RectTransform rt = Content.gameObject.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(860, 1141.9f);
        GameObject[] objects = GameObject.FindGameObjectsWithTag("EQ_Button");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]);
        int j = 0;
        foreach (CChar_EQ e in eq)
        {
            if (e.part == 2)
            {
                Object = Instantiate(Shoes, new Vector3(), Shoes.transform.rotation);
                Object.transform.SetParent(Content.transform);
                Object.transform.position = new Vector3(1250.385f, -748.906f - 180 * j, 0);

                Text[] trSphereList = Object.gameObject.GetComponentsInChildren<Text>();
                Image[] im = Object.gameObject.GetComponentsInChildren<Image>();
                im[1].GetComponent<Image>().sprite = e.image;
                if (e.speed > 0)
                    trSphereList[0].text = "능력 : " + e.speed + "% 스피드 증가";
                else if (e.hp > 0)
                    trSphereList[0].text = "능력 : " + e.hp + "% hp 증가";
                else if (e.money > 0)
                    trSphereList[0].text = "능력 : " + e.money + "% 돈 획득량 증가";
                else if (e.exp > 0)
                    trSphereList[0].text = "능력 : " + e.exp + "% 경험치 획득량 증가";
                else if (e.nd > 0)
                    trSphereList[0].text = "능력 : " + e.nd + "% 회피";
                else if (e.def > 0)
                    trSphereList[0].text = "능력 : " + e.def + "% 방어력 증가";
                trSphereList[1].text = e.txt;
                trSphereList[2].text = e.name;
                j++;
            }
        }
    }
}
