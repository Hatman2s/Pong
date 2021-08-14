using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 MoveDirection;

    void Update()
    {
        ProcessInputs();
      }
    private void FixedUpdate()
    {
        Move(); 
    }
    void ProcessInputs()
    {
        float moveY = Input.GetAxisRaw("Vertical all");
        float moveX = Input.GetAxisRaw("Horizontal");

        MoveDirection = new Vector2(moveY,moveX);

    }
    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.y*0,MoveDirection.x*movespeed); 
    }
}
