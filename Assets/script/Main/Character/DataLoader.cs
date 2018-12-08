using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    


    // Use this for initialization
    void Start () {

        List<Dictionary<string, object>> charData = CSVReader.Read("CSV/char1csv");

    


        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
