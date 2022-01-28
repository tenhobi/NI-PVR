using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[RequireComponent(typeof(Collider))]
public class IgnoreHands : MonoBehaviour
{
    void Awake()
    {
        GameObject[] hands = GameObject.FindGameObjectsWithTag("Hand");

        foreach (GameObject hand in hands) {
            Physics.IgnoreCollision(hand.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
