using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour {

    public GameObject followerObj;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-6, -4);
            float y = Random.Range(0, 1);
            float z = Random.Range(-3, -2);

            Vector3 pos = new Vector3(x, y, z);
            GameObject temp = Instantiate(followerObj);
            temp.transform.position = pos;
        }
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
