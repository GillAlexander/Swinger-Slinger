using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singelton<InputManager>
{
    private Rigidbody playerRb;
    private void Start()
    {
        playerRb = Player.GetInstance().GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRb.velocity = new Vector3(0,0,2);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.velocity = new Vector3(-2, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.velocity = new Vector3(2, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRb.velocity = new Vector3(0, 0, -2);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            playerRb.velocity = new Vector3(2, 0, 2);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            playerRb.velocity = new Vector3(2, 0, -2);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            playerRb.velocity = new Vector3(-2, 0, -2);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            playerRb.velocity = new Vector3(-2, 0, 2);
        }
    }
}
