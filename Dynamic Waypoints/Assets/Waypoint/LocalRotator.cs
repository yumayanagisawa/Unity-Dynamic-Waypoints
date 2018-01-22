using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalRotator : MonoBehaviour {
    private Vector3 rotDir;
    float rotSpeed;

    // Use this for initialization
    void Start()
    {
        float x = Random.value;
        float y = Random.value;
        float z = Random.value;
        rotDir = new Vector3(x, y, z);
        rotDir.Normalize();
        rotSpeed = Random.value * 180;
    }

    // Update is called once per frame
    void Update()
    {
        // rotate
        gameObject.transform.Rotate(rotDir * Time.deltaTime * rotSpeed);
    }
}
