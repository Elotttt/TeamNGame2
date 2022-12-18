using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;

    public bool MailCount;
    float horizontal;
    float vertical;
    //float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    public bool recoveringFromHit = false;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        recoveringFromHit = VariableTransfer.playerRecovering;
    }

    void Update()
    {
        Movement();
        VariableTransfer.playerRecovering = recoveringFromHit;
    }

    private void Movement()
    {
        if (!recoveringFromHit)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
            transform.Translate(new Vector3(horizontal, 0, vertical) * runSpeed * Time.deltaTime);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            recoveringFromHit = true;
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
