using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill : MonoBehaviour {
    public GameObject Skill_Icon;
    public GameObject Skill_motion;
    public static bool skill_check = false;
    public GameObject nd_motion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Move.nd_check == true)
        {
            StartCoroutine(check());
        }
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

    IEnumerator check()
    {
        Move.nd_check = false;
        nd_motion.SetActive(true);
        yield return new WaitForSeconds(3f);
        nd_motion.SetActive(false);
        yield return null;
    }
}
