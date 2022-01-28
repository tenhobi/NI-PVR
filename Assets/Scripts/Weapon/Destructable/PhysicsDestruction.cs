using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsDestruction : MonoBehaviour, IDestructable
{
    [SerializeField] private int score;

    private Rigidbody rigidBody;


    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void TakeDamage(Weapon weapon, Projectile projectile, Vector3 contactPoint)
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().Score(score);
    }
}
