using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
    }

    void Update()
    {


    }
}