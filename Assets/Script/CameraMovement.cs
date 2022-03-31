using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    protected Joystick joystick;
  


    // camera
    [SerializeField] protected float camSpeed = -0.5f;
    
    protected float x;
    protected float y;
    protected Vector3 rotateValue;



    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    void Update()
    {
        // camera
        x = joystick.Horizontal;
        y = joystick.Vertical;
        rotateValue = new Vector3(y, x * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        transform.eulerAngles += rotateValue * camSpeed;         
    }
}
