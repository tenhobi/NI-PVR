using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    private float rotationSpeed;
    private Vector3 pivot;
    private float initAngle;

    void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject target in targets) {
            Physics.IgnoreCollision(target.GetComponent<Collider>(), GetComponent<Collider>());
        }

        pivot = Vector3.zero;
        rotationSpeed = Random.Range(10.0f, 20.0f);
        if (Random.value >= 0.5f) {
            rotationSpeed = -rotationSpeed;
        }

        initAngle = Random.Range(0.0f, 360.0f);

        transform.position = new Vector3(5, Random.Range(1.0f, 7.0f), Random.Range(4.0f, 10.0f));
        transform.RotateAround(Vector3.zero, Vector3.up, initAngle);
    }
    
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
