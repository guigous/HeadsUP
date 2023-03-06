using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Instantiate(playerPrefabs[PlayerPrefs.GetInt("Personagem1")], spawnPoint[0].position, Quaternion.identity);

        Instantiate(playerPrefabs[PlayerPrefs.GetInt("Personagem2")], spawnPoint[1].position, Quaternion.identity);
    }

}
