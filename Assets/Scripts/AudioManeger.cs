using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManeger : MonoBehaviour
{
    private static AudioManeger instance;
    public static AudioManeger Instance { get { return instance; } }

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource backAudioSource;
    [SerializeField] AudioClip die, hit, point, music;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        backAudioSource = GetComponent<AudioSource>();
        //BackGroundMusic();
    }
   

    
    public void PlayDieAudio()
    {
        audioSource.clip = die;
        audioSource.Play();
    }
    public void PlayHitAudio()
    {
        audioSource.clip = hit;
        audioSource.Play();
    }
    public void PlayPointAudio()
    {
        audioSource.clip = point;
        audioSource.Play();
    }
    public void BackGroundMusic()
    {
        backAudioSource.Play();
    }
    
    // The one that's Subscribe event
    // Subscribe
}

