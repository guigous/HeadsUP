using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPrefabs;

    [SerializeField] private Transform[] spawnPoint;

    

    private void Start()
    {
        SpawnPlayer1();
        SpawnPlayer2();



    }

    private void SpawnPlayer1()
    {

        int personagemSelecionado = PlayerPrefs.GetInt("Personagem{0}");
        GameObject prefab = playerPrefabs[personagemSelecionado];
        GameObject clone = Instantiate(prefab, spawnPoint[0].transform.position, Quaternion.identity);




    }
    private void SpawnPlayer2()
    {

    }



}    

