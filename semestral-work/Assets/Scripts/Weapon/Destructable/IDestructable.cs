using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestructable
{
    void TakeDamage(Weapon weapon, Projectile projectile, Vector3 contactPoint);
}
