using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Delivered!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Left!");
    }
}
