using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;


    public AudioSource audioS;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DangerousCabinet"))
        {
            auxInSnapshot.TransitionTo(0.5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DangerousCabinet"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
    }
}
