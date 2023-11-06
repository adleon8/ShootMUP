using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Author: [Leon, Alyssa]
 * Date: [10/24/2023]
 * [This file contains functions to be used for control and player input.]
 */


public class ShipContainer : MonoBehaviour
{
    // -----PLAYER MOVEMENT AND POSITION VARIABLES-----
    public float speed = 10f;                   // Speed. 
    private Vector3 moveVector = Vector3.left;  // Movement vector.
    PlayerInput playerActions;                  // Input system variable.
    private Rigidbody rigidbody;                // Rigidbody.
    private Vector3 startPosition;              // Start position for respawn variables.
    public GameObject spawn;                    // Spawn.

    // -----LASER VARIABLES-----
    public Transform firePoint;                 // Sets the point from which a laser will be fired from the gun. 
    public GameObject laserPrefab;              // Laser prefab.
    public bool allowFire = true;               // Decides whether to enable shooting.

    // -----RESPAWN VARIABLES-----
    public float health = 3;
    public bool gameActive;
    public bool isRespawning;

    private void Awake()
    {
        gameActive = false;

        // Spawn position.
        transform.position = spawn.transform.position;
        startPosition = transform.position;

        // Enable input class.
        playerActions = new PlayerInput();       
        playerActions.Enable();

        // Rigidbody.
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // When the game is inactive.
        if (!gameActive && isRespawning)
        {
            Destroy(GameObject.FindWithTag("BaseEnemy"));
            Destroy(GameObject.FindWithTag("FastEnemy"));
            Destroy(GameObject.FindWithTag("ZigEnemy"));
            Destroy(GameObject.FindWithTag("FrozenEnemy"));
            Destroy(GameObject.FindWithTag("StalkerEnemy"));
        }

        // Checks if the player has pressed space to activate the game.
        if (!gameActive && (Input.anyKey))
        {
            isRespawning = false;
            gameActive = true;
        }



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

        // Checks if player is pressing space to shoot and if allowFire is true.
        if (Input.GetButtonDown("Fire1") && (allowFire))
        {
            // Starts the laser coroutine. 
            StartCoroutine(Laser());
        }
    }

    // -----METHODS-----

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BaseEnemy")
        {            
            Damage();
        }
        if (other.gameObject.tag == "ZigEnemy")
        {
            Damage();
        }
        if (other.gameObject.tag == "FrozenEnemy")
        {
            Damage();
        }
        if (other.gameObject.tag == "StalkerEnemy")
        {
            Damage();
        }
        if (other.gameObject.tag == "FastEnemy")
        {
            Damage();
        }
    }

    private void Death()
    {
        gameActive = false;
        isRespawning = true;
        transform.position = startPosition;
        health = 3;
    }

    private IEnumerator Blink()
    {
        for (int index = 0; index < 4; index++)
        {
            if (index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }

    public void Damage()
    {
        health--;
        StartCoroutine(Blink());
        if (health <= 0)
        {
            Death();
        }
    }

    private IEnumerator Laser()
    {
        allowFire = false;
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(.05f);
        allowFire = true;
    }

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
        return Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed;
    }

    public bool IsMovingLeft()
    {
        // Checks and returns true if any of the keys are pressed.
        return Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed;
    }
}
