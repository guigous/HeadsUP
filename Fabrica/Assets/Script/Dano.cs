using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public Rounds roundManager;
    public Transform respawnPoint;


    private void Start()
    {
        roundManager = FindAnyObjectByType<Rounds>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("head"))
        {

            roundManager.Player1GanhouRound();


        }

    }
}  