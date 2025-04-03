using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

//attach this script to the second object which is the one being changed (door) by the first (key)

public class MySimpleIDMatch : MonoBehaviour
{
    public Id id;

    //we need two separate possible events for the two possible outcomes
    public UnityEvent matchEvent, noMatchEvent;


    //what happens when the player enters the collider
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Trigger entered by: " + other.name);

        //get the 'other' collider's ID from the MySimpleIDBehavior script
        var otherID = other.GetComponent<MySimpleIDBehavior>();

        //check if the other id from above matches this script's id
        if(otherID.id == id) //== meaning "is equal to"
        {
            Debug.Log("Matched ID: " + id);

            matchEvent.Invoke();
        }
        else
        {
            Debug.Log("No match to: " + id);

            noMatchEvent.Invoke();
        }
    }
}


