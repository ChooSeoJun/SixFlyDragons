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

    public Button bgmWhat;
    public Button effectWhat;

    public Image on;
    public Image off;

    public Image option;

    

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

    public void OpenOption() {
        option.gameObject.SetActive(true);
    }

    public void exitOption() {
        option.gameObject.SetActive(false);
    }

    void Update()
    {
        BGM.gameObject.SetActive(playBGM);
        Effect.gameObject.SetActive(playEffect);

        if (playBGM)
            bgmWhat.image.sprite = on.sprite;
        else
            bgmWhat.image.sprite = off.sprite;

        if (playEffect)
            effectWhat.image.sprite = on.sprite;
        else
            effectWhat.image.sprite = off.sprite;

    }


}
