using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Controller2D))]
public class PlayerFire : MonoBehaviour
{
    float movespeed = 6f;
    float gravity = -20f;

    float jumpVelocity = 8f;
    Vector3 velocity;

    Controller2D controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Controller2D>();
    }

    void FixedUpdate()
    {
        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        } 

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        velocity.x = input.x * movespeed;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
