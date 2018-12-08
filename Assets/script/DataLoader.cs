using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    


    // Use this for initialization
    void Start () {

        List<Dictionary<string, object>> charData = CSVReader.Read("CSV/char1csv");

    for(var  i =0;i<charData.Count;i++)
        {
            Debug.Log(charData[i]["ch_index"]+" "+charData[i]["ch_id"] + " " + charData[i]["ch_name"] + " " + charData[i]["ch_shop"] + " " + charData[i]["ch_sh"] + " " + charData[i]["ch_speed"] + " " + charData[i]["ch_hp"] + " " + charData[i]["ch_spu"] + " " + charData[i]["ch_price"] + " " + charData[i]["ch_txt"]);
        }


        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
