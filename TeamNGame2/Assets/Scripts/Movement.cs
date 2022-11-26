using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody body;

    float horizontal;
    float vertical;
    //float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    void Start()
    {   
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * runSpeed * Time.deltaTime);
    }
}
