using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    private AudioSource audioSource;



    
    void Start()
    {
        //finds the audio source associated with the game object
        audioSource = GetComponent<AudioSource>();
    }

    //plays audio if collision happens
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
