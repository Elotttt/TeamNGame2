using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;

    float horizontal;
    float vertical;
    //float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    public bool recoveringFromHit = false;
    private WaitForSeconds recoveryTime = new WaitForSeconds(5f);

    void Start()
    {
        body = GetComponent<Rigidbody>();
        StartCoroutine(Recovery());
    }

    void Update()
    {
        Movement();
    }

    public void Death()
    {
        transform.position = new Vector3(0, 0, 0);
        recoveringFromHit = true;
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

    private IEnumerator Recovery()
    {
        if (recoveringFromHit)
        {
            yield return recoveryTime;
            recoveringFromHit = false;
            Debug.Log("Recovered!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Death();
        }
    }
}
