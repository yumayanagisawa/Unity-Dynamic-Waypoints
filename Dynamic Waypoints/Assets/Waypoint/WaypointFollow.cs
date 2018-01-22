using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour {
    public UnityStandardAssets.Utility.WaypointCircuit circuit;
    //public GameObject[] waypoints;
    int currentWP = 0;
    public float speed = 30.0f;
    float accuracy = 0.1f;//1.0f;
    float rotSpeed = 3.0f;

	// Use this for initialization
	void Start () {
        // if you don't use standard assets
        //waypoints = GameObject.FindGameObjectsWithTag("waypoint");
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (circuit.Waypoints.Length == 0) return;
        //if (waypoints.Length == 0) return;


        Vector3 lookAtGoal = circuit.Waypoints[currentWP].position;
        //Vector3 lookAtGoal = waypoints[currentWP].transform.position;
        Vector3 direction = lookAtGoal - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

        if (direction.magnitude < accuracy)
        {
            currentWP++;
            if (currentWP >= circuit.Waypoints.Length) //waypoints.Length)// circuit.Waypoints.Length)
            {
                currentWP = 0;
            }
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime);
	}
}
