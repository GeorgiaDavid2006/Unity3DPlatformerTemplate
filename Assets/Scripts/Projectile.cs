using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Reference to projectile's rigidbody
    Rigidbody projectileRb;

    void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();
    }

    public void Launch(Vector3 direction, float force)
    {
        projectileRb.AddForce(direction * force);
    }

}
