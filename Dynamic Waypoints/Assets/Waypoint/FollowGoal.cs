using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGoal : MonoBehaviour {

	public Transform goal;
	float speed = 2.0f;
	float accuracy = 1.0f;
	float rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
        speed = Random.Range(0.6f, 3);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 lookAtGoal = goal.position;//new Vector3(goal.position.x, 
										//this.transform.position.y, 
										//goal.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
												Quaternion.LookRotation(direction), 
												Time.deltaTime*rotSpeed);

		this.transform.Translate(0,0,speed*Time.deltaTime);
	}
}
