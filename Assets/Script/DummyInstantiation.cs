using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyInstantiation : MonoBehaviour
{
    [SerializeField] protected GameObject[] dummies = new GameObject[4];

    [SerializeField] protected int dummyMinimum; // minimum number of whole targets
    [SerializeField] protected float distance;

    protected Vector3 Location;

    [HideInInspector]
    public static int dummyQuantity; // amount of brand-new dummy

    void Start()
    {
        CreateField();
    }
    private void Update()
    {
        if (dummyQuantity < dummyMinimum) CreateField(); // if we haven't enough brand-new dummy, we replenish the field
    }

    protected void CreateField() // procedure for creating dummyMinimum-dummyMinimum+4(random) dummies
    {
        int quantity;
        int N = dummies.Length;
        int temp = dummyMinimum/N; // for random limits;
        for (int i = 0; i < N; i++)
        {
            quantity = Random.Range(temp, temp+4);
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
