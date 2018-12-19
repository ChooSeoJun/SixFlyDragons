using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage_Click : MonoBehaviour {
    public Button button;
    int stageLavel;
    public GameObject PauseGUI;
    // Use this for initialization
    void Start () {
        button = GetComponent<Button>();
        stageLavel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stage_choose(Button button)
    {
        switch (button.name)
        {
            case "Stage_1":
                SceneManager.LoadScene(3);
                break;
            case "Stage_2":
                Debug.Log("2");
                if(Global.stage >= 2)
                SceneManager.LoadScene(4);
                break;
            case "Stage_3":
                Debug.Log("3");
                if (Global.stage >= 3)
                    SceneManager.LoadScene(5);
                break;
            case "Stage_4":
                Debug.Log("4");
                if (Global.stage >= 4)
                    SceneManager.LoadScene(6);
                break;
            case "Stage_5":
                Debug.Log("5");
                if (Global.stage >= 5)
                    SceneManager.LoadScene(7);
                break;
            case "Keep":
                Time.timeScale = 1;
                PauseGUI.SetActive(false);
                break;
            case "Main":
                SceneManager.LoadScene("MainPage");
                Time.timeScale = 1;
                break;
            case "replay":
                Debug.Log("5");
                SceneManager.LoadScene(stageLavel);
                Time.timeScale = 1;
                break;
            case "NextStage":
                Debug.Log("5");
                SceneManager.LoadScene(stageLavel + 1);
                Time.timeScale = 1;
                break;
            default:
                break;
        }
    }

}
