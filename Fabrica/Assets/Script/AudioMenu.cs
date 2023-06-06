using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMenu : MonoBehaviour
{
    AudioSource MyAudioSource;

    public AudioClip menuMusic;
    public AudioClip gameplayMusic;

    private void Awake()
    {
        AudioMenu[] gameObj = FindObjectsOfType<AudioMenu>();
        if(gameObj.Length > 1)
        {
            Destroy(gameObject);
        }
        else
            DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        MyAudioSource.clip = menuMusic;
        MyAudioSource.loop = true;
        MyAudioSource.Play();

        SceneManager.sceneLoaded += TrocarMusicaAoEntrarNaCena;
    }

    void TrocarMusicaAoEntrarNaCena(Scene cena, LoadSceneMode modo)
    {
        if (cena.name == "TestEnviroment" || cena.name == "Fase" || cena.name == "Jogo")
        {
            MyAudioSource.Stop();
            MyAudioSource.clip = gameplayMusic;
            MyAudioSource.Play();
        }
        if(cena.name == "Menu")
        {
            MyAudioSource.Stop();
            MyAudioSource.clip = menuMusic;
            MyAudioSource.Play();
        }
    }

    void Update()
    {


    }
}