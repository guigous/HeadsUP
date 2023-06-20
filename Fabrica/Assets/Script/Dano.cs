using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public Rounds roundManager;
    public Transform respawnPoint;
    public Avatar avatar;
    


    private void Start()
    {
        roundManager = FindAnyObjectByType<Rounds>();
        //avatar = FindAnyObjectByType<Avatar>();
        avatar = GetComponentInParent<Avatar>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("head") && avatar.playerId == 1)
        {

            roundManager.Player1GanhouRound();


        }
        
        if (other.CompareTag("head") && avatar.playerId == 2)
        {

            roundManager.Player2GanhouRound();


        }

    }
}  