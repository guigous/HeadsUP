using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGameplay : MonoBehaviour
{
    AudioSource MyAudioSource;

    AudioClip jumpClip;
    AudioClip winClip;
    AudioClip runClip;

    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        MyAudioSource.Play();
    }

    void Update()
    {


    }
}
