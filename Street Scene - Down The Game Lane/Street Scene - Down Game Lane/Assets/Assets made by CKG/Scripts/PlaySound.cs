using UnityEngine;

using System.Collections;

using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{

    public AudioSource SoundSouce;
    public AudioClip Sound;

    private bool hasPlayedAudio;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasPlayedAudio == false)
            SoundSouce.PlayOneShot(Sound);
            hasPlayedAudio = false;

    }











}





