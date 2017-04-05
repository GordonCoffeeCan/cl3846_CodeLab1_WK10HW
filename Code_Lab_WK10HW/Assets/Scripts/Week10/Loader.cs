using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AsteriodData loadAD = new AsteriodData("Asteroid.json");

        print(loadAD.position);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
