using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int damage = 1;
    public GameObject fx;

    

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            
            Instantiate(fx, transform.position, Quaternion.identity);

             Destroy(gameObject);
        }

    }

}