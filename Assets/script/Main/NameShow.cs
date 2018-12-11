using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameShow : MonoBehaviour {
    public Text name_text;
    // Use this for initialization
    void Start () {
        name_text.text = InputProcessor.UserNick.ToString();
    }
	

}
