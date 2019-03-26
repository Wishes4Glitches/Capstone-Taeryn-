using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;

        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown("left shift"))
        {
            speed = speed * 2;
        }

        if (Input.GetKeyUp("left shift"))
        {
            speed = 10.0f;
        }
    }
}
