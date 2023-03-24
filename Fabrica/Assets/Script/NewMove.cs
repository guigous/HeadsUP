using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private InputAction moveAction;
    private Vector2 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Awake()
    {
        moveAction = new InputAction("move", InputActionType.Value, "<Gamepad>/leftStick");
        moveAction.Enable();
        
    }

    private void Update()
    {
        moveDirection = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveDirection.x, 0f, moveDirection.y) * moveSpeed * Time.fixedDeltaTime;
        transform.position += movement;
    }
    public void SetMoviment(InputAction.CallbackContext value)
    {
       moveDirection = value.ReadValue<Vector2>();

    }

    public void SetJump(InputAction.CallbackContext value)
    {
        rb.AddForce(Vector2.up * 100);
    }

}
