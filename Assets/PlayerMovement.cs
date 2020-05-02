using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;


    }

    void FixedUpdate()
    {
        //move the character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}

