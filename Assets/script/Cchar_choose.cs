using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cchar_choose : MonoBehaviour {
     GameObject GameObject;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Cchar_Mgr.ch[0].ch_use);
    }
    public void Ch_choose(Button button)
    {
        if (button.name == "ch_1")
        {
            for (int i = 0; i < 3; i++)
            {
                Cchar_Mgr.ch[i].ch_use = false;
            }
            Cchar_Mgr.ch[0].ch_use = true;
        }
        else if (button.name == "ch_2")
        {

            for (int i = 0; i < 3; i++)
            {
                Cchar_Mgr.ch[i].ch_use = false;
            }
            Cchar_Mgr.ch[1].ch_use = true;
        }
        else if (button.name == "ch_3")
        {
            for (int i = 0; i < 3; i++)
            {
                Cchar_Mgr.ch[i].ch_use = false;
            }
            Cchar_Mgr.ch[2].ch_use = true;
        }
      
    }
}
