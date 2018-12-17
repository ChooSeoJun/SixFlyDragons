using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage_Click : MonoBehaviour {
    public Button button;
	// Use this for initialization
	void Start () {
        button = GetComponent<Button>();
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
                break;
            case "Stage_3":
                Debug.Log("3");
                break;
            case "Stage_4":
                Debug.Log("4");
                break;
            case "Stage_5":
                Debug.Log("5");
                break;
            default:
                break;
        }
    }

}
