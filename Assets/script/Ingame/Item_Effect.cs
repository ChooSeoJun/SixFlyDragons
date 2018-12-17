using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Effect : MonoBehaviour {
    public GameObject effect;
	// Use this for initialization
	void Update () {
        if(Move.effect == true)
            StartCoroutine(ItemEffect());
    }
    IEnumerator ItemEffect()
    {
        effect.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        effect.SetActive(false);
        Move.effect = false;
        yield return null;
    }
}
