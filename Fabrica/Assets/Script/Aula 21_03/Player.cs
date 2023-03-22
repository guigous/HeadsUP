using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movimento;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(movimento.x,movimento.y) * Time.fixedDeltaTime *force);
        
    }
}
