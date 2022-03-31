using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float timerEtalon; // lifetime of projectile 
    public float explosionPower; 
    public float annihilationRadius; 
    public float shockwaveRadius;

    protected float timer; 

    private void Start()
    {
        timer = timerEtalon;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 explosionPos = transform.position;
        Collider[] collider = Physics.OverlapSphere(explosionPos,shockwaveRadius);
        foreach(Collider hit in collider)
        {
            if (hit.tag == "TARGET")
            {
                Rigidbody hitted = hit.GetComponent<Rigidbody>();
                if ((hitted != null) && (Vector3.Distance(hitted.position, explosionPos) < annihilationRadius))
                    Destroy(hit.gameObject);
                else
                {
                    hitted.useGravity = true;
                    hitted.AddExplosionForce(explosionPower, explosionPos, shockwaveRadius, 2.0f);
                    Destroy(hit.gameObject, 10);
                }
            }
        }
        DummyInstantiation.dummyQuantity--;
        Destroy(gameObject);
    }
}
