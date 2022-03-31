using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    protected ShootButton shootButton;

    [SerializeField] protected  Rigidbody projectileCube; 
    [SerializeField] protected  Rigidbody projectileSphere;

    [SerializeField] protected  float speed; // speed of projectile
    [SerializeField] protected  float delayEtalon; // delay before firing

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
