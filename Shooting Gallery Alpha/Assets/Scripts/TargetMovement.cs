using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TargetMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float Speed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.right * Speed;
    }

    private void Update()
    {
        
    }
}
