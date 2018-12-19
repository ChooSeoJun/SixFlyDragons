using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameClear : MonoBehaviour {
    public GameObject clearGUI;
    public GameObject failGUI;
    public Text[] texts;
    public float time = 0;
    public Text timerText;
    bool bPauseGame = false;
    int stageLavel;
    public int bestcheck = 0;
    public int a;
    public GameObject check;


    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Timer();
    }


    void Timer() {  
        time += Time.deltaTime;

        timerText.text = "Time : " + string.Format("{0:N2}", time); 
        if(bPauseGame)
        {
            if(Global.stage < a+2)
            {
                Global.stage = a + 2;
            }
            Global.exp_value = (long)(1000 / time);
            Global.money = (long)(1000 / time);
            if (Global.Best[a] > time)
            {
                Global.Best[a] = time;
                bestcheck = 1;
                check.SetActive(true);
            } 
            texts[0].text = string.Format("{0:N2}", time);
            texts[1].text = string.Format("{0:N2}", Global.Best[a]);
            texts[2].text = ((long)(1000 / time) + (bestcheck * 50)).ToString();
            texts[3].text = ((long)(1000 / time)).ToString();
        }
    }


    public void OnTriggerEnter2D(Collider2D collider)
    {       
        if (collider.tag == "Player")
        {
            bPauseGame = true;
            clearGUI.SetActive(true);
            Time.timeScale = 0; 
            Debug.Log("1");
        }
    } 
}
