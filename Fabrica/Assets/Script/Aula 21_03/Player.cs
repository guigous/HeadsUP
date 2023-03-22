using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movimento;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        rb.AddForce(Vector2.up * 100);
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(movimento.x,movimento.y) * Time.fixedDeltaTime *300);
    }
}
