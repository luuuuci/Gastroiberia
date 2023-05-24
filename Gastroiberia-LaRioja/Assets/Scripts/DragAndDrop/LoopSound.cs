using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopSound : MonoBehaviour
{
     public AudioClip soundClip;
    private AudioSource audioSource;

    void Start()
    {
        // Create an AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;

        // Set the loop property to true to enable looping
        audioSource.loop = true;

        // Play the sound
        audioSource.Play();
    }
}
