using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrows : MonoBehaviour
{
    public float Speed;

    float MovementX;
    float Movementy;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovementX = 0;
        Movementy = 0;
    }

    private void Update()
    {
        rb.velocity = new Vector2(MovementX * Speed * Time.deltaTime, Movementy * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Movementy = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Movementy = -1;
        }
    }

}
