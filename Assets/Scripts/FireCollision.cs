using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour
{
    // Player collides with fire
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fire"))
        {
            Debug.Log("It burns!!!");
        }
    }
}
