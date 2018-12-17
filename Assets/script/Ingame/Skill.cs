using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill : MonoBehaviour {
    public GameObject Skill_Icon;
    public GameObject Skill_motion;
    public static bool skill_check = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Skill_Icon.GetComponent<Image>().fillAmount == 1)
            {
                skill_check = true;
                Skill_motion.SetActive(true);
                Skill_Icon.GetComponent<Image>().fillAmount = 0;
            }
        }
        Skill_Icon.GetComponent<Image>().fillAmount += 0.001f;

    }
}
