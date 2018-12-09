using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOption : MonoBehaviour
{
    public bool playEffect = true;
    public bool playBGM = true;

    public AudioSource BGM;
    public AudioSource Effect;

    public Text bgmWhat;
    public Text effectWhat;


    public void playSoundEffect(string snd) {
       if (playEffect)
            GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    public void playSoundBGM(string snd) {
        if (playBGM)
            GameObject.Find(snd).GetComponent<AudioSource>().Play();
    }

    public void boolEffect() {
        playEffect = !playEffect;

    }

    public void boolBGM() {
        playBGM = !playBGM;

    }


  
    void Update()
    {
        BGM.gameObject.SetActive(playBGM);
        Effect.gameObject.SetActive(playEffect);

        if (playEffect)
            effectWhat.text = "효과음 : on";
        else
            effectWhat.text = "효과음 : off";

        if (playBGM)
            bgmWhat.text = "배경음 : on";
        else
            bgmWhat.text = "배경음 : off";
    }


}
