using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        //print("true");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        //print("false");
    }
}
