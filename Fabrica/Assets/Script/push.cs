using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    float force = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        direction = new Vector2(hor, ver);

        rb.AddForce(direction * force);
    }
}