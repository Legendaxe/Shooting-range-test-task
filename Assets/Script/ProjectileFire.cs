using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    protected ShootButton shootButton;

    public Rigidbody projectileCube; 
    public Rigidbody projectileSphere;

    public float speed; // speed of projectile
    public float delayEtalon; // delay before firing

    protected int projType;
    protected float delay;


    void Start()
    {
        shootButton = FindObjectOfType<ShootButton>();
        delay = 0;
    }
    void Update()
    {
        if (shootButton.pressed && (delay <= 0))
        {
            delay = delayEtalon;
            projType = Random.Range(0, 2);
            if (projType == 0)
            {
                Rigidbody p = Instantiate(projectileCube, transform.position, transform.rotation);
                p.velocity = transform.forward * speed;
            }
            else
            {
                Rigidbody p = Instantiate(projectileSphere, transform.position, transform.rotation);
                p.velocity = transform.forward * speed;
            }
        }
        delay -= Time.deltaTime;
    }
}
