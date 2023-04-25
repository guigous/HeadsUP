using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    AudioSource MyAudioSource;

    public AudioClip menuMusic;

    private void Awake()
    {
        AudioMenu[] gameObj = FindObjectsOfType<AudioMenu>();
        if(gameObj.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        MyAudioSource.Play();
    }

    void Update()
    {


    }
}