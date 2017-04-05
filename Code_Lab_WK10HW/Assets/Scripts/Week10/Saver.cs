using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] asteriods = GameObject.FindGameObjectsWithTag("Asteroid");

        Vector3 pos = asteriods[0].transform.position;
        Vector3 scale = asteriods[0].transform.localScale;

        AsteriodData ad = new AsteriodData(pos, scale);

        ad.Save("Asteroid.json");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
