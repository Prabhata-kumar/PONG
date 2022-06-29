using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPadal : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rigidbody;
    public Vector2 direction;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            Rigidbody.AddForce(direction * Speed);
        }
    }


}
