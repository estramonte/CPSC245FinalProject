using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds Instance;

    public AudioClip MenuMusic;
    public AudioClip InGameMusic;
    public AudioClip ResultMusic;
    public AudioClip ButtonNoises;
    public AudioClip HitMade;
    public AudioClip Countdown;

    private AudioSource audioSource;

    public void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayMenuMusic()
    {
        audioSource.PlayOneShot(MenuMusic);
    }

    public void PlayInGameMusic()
    {
        //audioSource.PlayOneShot(InGameMusic);
        audioSource.clip = InGameMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayResultMusic()
    {
        audioSource.PlayOneShot(ResultMusic);
    }

    public void PlayButtonNoises()
    {
        audioSource.PlayOneShot(ButtonNoises);
    }

    public void PlayHitMade()
    {
        audioSource.PlayOneShot(HitMade);
    }

    public void PlayCountdown()
    {
        audioSource.PlayOneShot(Countdown);
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
