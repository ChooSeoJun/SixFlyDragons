using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameClear : MonoBehaviour {
    public GameObject clearGUI;
    public GameObject failGUI;
    //public Text[] texts;
    public static float time = 0;
    float record = 0;
    // Use this for initialization
    void Start () {
       // texts = GetComponent<Text[]>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Timer();
    }
    void Timer() { 
        time += Time.deltaTime;

        float t = time;
        Text uiText = GetComponent<Text>();
        uiText.text = "Time : " + string.Format("{0:N2}", time);
        }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player") {
            clearGUI.SetActive(true);
         }
    }


}
