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
        Spawn();



    }

    private void Spawn()
    {
       GameObject p1 =  Instantiate(playerPrefabs[PlayerPrefs.GetInt("Personagem2")], spawnPoint[0].position, Quaternion.identity);
        //p1.GetComponent<PlayerInput>().actions.FindActionMap("Player1").Enable();


        GameObject p2 = Instantiate(playerPrefabs[PlayerPrefs.GetInt("Personagem1")], spawnPoint[1].position, Quaternion.identity);
        // p2.GetComponent<PlayerInput>().actions.FindActionMap("Player2").Enable();

    }



}    

