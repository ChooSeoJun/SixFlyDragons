using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour {
    public GameObject clearGUI;
    public GameObject failGUI;
    public Text[] texts;
    public static float time = 0;
    public static float record = 0;
    
    public Text timerText;
    bool bPauseGame = false;
  
    void Start () {
        //texts = GetComponent<Text[]>(); 
	}
	
	// Update is called once per frame
	void Update () {
        Timer();
    }


    void Timer() {  
        time += Time.deltaTime;

        //float t = time;
        //Text uiText = GetComponent<Text>();
        //uiText.text = "Time : " + string.Format("{0:N2}", time);

        timerText.text = "Time : " + string.Format("{0:N2}", time); 
        if(bPauseGame)
            texts[0].text = string.Format("{0:N2}", time);  
    }


    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            clearGUI.SetActive(true);

            Time.timeScale = 0; 

            record = time;
            Global.exp_value = (long)(1000 / time);
            Global.money = (long)(1000 / time);
            texts[2].text = (1000 / time).ToString();
            texts[3].text = (1000 / time).ToString();
            bPauseGame = true;
        }
    } 
}
