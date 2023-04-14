using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{   
    public int speed;
    Rigidbody rb;
    Vector3 movement;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
    }
    void FixedUpdate()
    {
        Move();
    }

    void InputPlayer()
    {
        horizontal= Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");
    }

    void Move()
    {
        movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();
        rb.MovePosition(transform.position + (movement * speed * Time.deltaTime));
    }
}
