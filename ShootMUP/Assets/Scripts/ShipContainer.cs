using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Author: [Leon, Alyssa]
 * Date: [10/24/2023]
 * [This file contains functions to be used for control and player input.]
 */

// Player Movement

public class ShipContainer : MonoBehaviour
{
    // -----VARIABLES-----
    public float speed = 10f;
    private Vector3 moveVector = Vector3.left;
    PlayerInput playerActions;

    private void Awake()
    {
        playerActions = new PlayerInput();
        // Enable input class
        playerActions.Enable();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Gets Vector2 data from the move action composite
        Vector2 moveVec = playerActions.PlayerInGameActions.WASDMovement.ReadValue<Vector2>();

        // Gets Vector2 data from the move action composite
        Vector2 movementVec = playerActions.PlayerInGameActions.ArrowMovement.ReadValue<Vector2>();

        // Calculate moving direction by normalizing the vector (making it a unit vector).
        Vector3 moveDirection = new Vector3(moveVec.x, 0, moveVec.y).normalized;

        // Calculate moving direction by normalizing the vector (making it a unit vector).
        Vector3 movementDirection = new Vector3(movementVec.x, 0, movementVec.y).normalized;

        // Apply the move vector to the player
        transform.Translate(moveDirection * speed * Time.deltaTime);

        // Apply the move vector to the player
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    // -----METHODS-----

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        GetComponent<Rigidbody>().AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5f, ForceMode.Force);
    }

    public void Movement(InputAction.CallbackContext context)
    {
        Vector2 movementVec = context.ReadValue<Vector2>();
        GetComponent<Rigidbody>().AddForce(new Vector3(movementVec.x, 0, movementVec.y) * 5f, ForceMode.Force);
    }

    public bool IsMovingRight()
    {
        // Checks and returns true if any of the keys are pressed.
        return Keyboard.current.rightArrowKey.isPressed;
        return Keyboard.current.dKey.isPressed;
    }

    public bool IsMovingLeft()
    {
        // Checks and returns true if any of the keys are pressed.
        return Keyboard.current.leftArrowKey.isPressed;
        return Keyboard.current.aKey.isPressed;
    }
}
