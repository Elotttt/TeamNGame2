using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Movement playerMovementReference;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //playerMovementReference.Death();
            other.transform.position = new Vector3(0, 0, 0);
        }
    }
}
