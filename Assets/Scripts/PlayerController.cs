using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private SpriteRenderer spriteRenderer;

    private float horizontalAixsRaw;

    [SerializeField] float speed = 50.0f;
    [SerializeField] float jumpHeight = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            horizontalAixsRaw = Input.GetAxisRaw("Horizontal");

            Vector2 movement = new Vector2(horizontalAixsRaw, 0);

            rigidBody2D.MovePosition(rigidBody2D.position + movement * speed * Time.deltaTime);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumped");
            rigidBody2D.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }
}
