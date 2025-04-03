using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleEventTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;

    //when another collider makes contact with this object
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();

        UnityEngine.Debug.Log("Player has interacted with " + gameObject.name);
    }


}
