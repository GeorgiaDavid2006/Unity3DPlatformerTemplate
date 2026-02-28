using JetBrains.Annotations;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Reference to projectile's rigidbody
    Rigidbody projectileRb;

    //Reference to player

    void Awake()
    {
        projectileRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    public void Launch(Vector3 direction, float force)
    {
        projectileRb.AddForce(direction *  force);
    }

    
}
