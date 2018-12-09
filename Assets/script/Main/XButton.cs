using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// X버튼을 누르면 장비창을 닫는 코드
public class XButton : MonoBehaviour {
    public GameObject Page; // 창
    public void Click() // X를 클릭했을 때
    {
        Page.SetActive(false);
    }
}
