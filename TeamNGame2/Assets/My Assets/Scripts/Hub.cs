using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub : MonoBehaviour
{
    public GameObject playerReference;
    public Player playerScriptReference;

    private void Start()
    {
        //StartCoroutine(PlayerRecovery());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered hub!");
            StartCoroutine(PlayerRecovery());
        }
    }

    private IEnumerator PlayerRecovery()
    {
        if (playerScriptReference.recoveringFromHit == true)
        {
            yield return new WaitForSeconds(5);
            playerScriptReference.recoveringFromHit = false;
            Debug.Log("Recovered at Hub!");
        }
    }
}
