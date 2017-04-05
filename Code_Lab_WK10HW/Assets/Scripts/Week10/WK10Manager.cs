using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WK10Manager : MonoBehaviour {

    private ConstructorExample myLoader;

	// Use this for initialization
	void Start () {
        myLoader = new ConstructorExample();

        myLoader.temp = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
