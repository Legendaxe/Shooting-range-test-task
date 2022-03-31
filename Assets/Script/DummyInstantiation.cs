using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyInstantiation : MonoBehaviour
{
    public GameObject[] dummies = new GameObject[4];

    public int dummyMinimum; // minimum number of whole targets
    public float distance;

    [HideInInspector]
    public static int dummyQuantity; // amount of brand-new dummy
    public Vector3 Location;

    void Start()
    {
        CreateField();
    }
    private void Update()
    {
        if (dummyQuantity < dummyMinimum) CreateField(); // if we haven't enough brand-new dummy, we replenish the field
    }

    protected void CreateField() // procedure for creating 16-24(random) dummies
    {
        for (int i = 0; i < dummies.Length; i++)
        {
            int quantity;
            quantity = Random.Range(4, 6);
            for (int j = 0; j < quantity; j++)
            {
                CreateDummy(dummies[i]);
            }
        }
    }
    protected void CreateDummy(GameObject Dummy)
    {
        Location.x = Random.Range(-10, 10) + distance * RandomSign();
        Location.z = Random.Range(-10, 10) + distance * RandomSign();
        Location.y = 0.5f;
        Instantiate(Dummy, Location, Quaternion.identity);
        dummyQuantity++;
    }

    private int RandomSign()
    {
        return Random.value > 0.5f ? 1 : -1;
    }
  
}
