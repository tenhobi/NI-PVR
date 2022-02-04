using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[RequireComponent(typeof(Collider))]
public class IgnoreWeapons : MonoBehaviour
{
    void Awake()
    {
        GameObject[] weapons = GameObject.FindGameObjectsWithTag("Weapon");

        foreach (GameObject weapon in weapons) {
            Physics.IgnoreCollision(weapon.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
