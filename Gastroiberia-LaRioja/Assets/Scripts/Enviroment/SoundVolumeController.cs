using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolumeController : MonoBehaviour
{
     public Transform player;
    public AudioSource audioSource;
    public float maxDistance = 10f;
    public float maxVolume = 1f;

    private void Update()
    {
        // Calculate the distance between the player and the sound source
        float distance = Vector3.Distance(player.position, transform.position);

        // Calculate the volume based on the distance
        float volume = Mathf.Lerp(0f, maxVolume, 1f - (distance / maxDistance));

        // Set the volume of the audio source
        audioSource.volume = volume;
        audioSource.Play();
    }
}
