using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    CharacterController cc; 

    const float PIXEL_STEP = 16; // use to move perfect tile amounts

    Vector2 direction;

    void OnEnable()
    {
        movementAction.started += ctx => ProcessMove();
    }

    private void OnDisable()
    {
        movementAction.started -= ctx => ProcessMove();
    }


    InputAction movementAction;
    void Awake()
    {
        cc = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
        movementAction = playerInput.actions["Move"];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ProcessMove()
    {
        Vector2 dir = movementAction.ReadValue<Vector2>();
        cc.Move(dir);
    }
}
