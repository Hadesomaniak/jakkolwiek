using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 speed = new Vector2(10,10);
    public int jumpHeight = 5;
    
    void Update()
    {
            Move();   
    }

    public void Move()
    {
        float inputX = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(speed.x * inputX, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    } 
}
