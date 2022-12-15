using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub : MonoBehaviour
{
    public GameObject playerReference;
    public Player playerScriptReference;
    public bool inHub = false;

    private void Start()
    {
        Debug.Log(VariableTransfer.points.ToString());
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene("IdleGame");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inHub = true;
            Debug.Log("Entered hub!");
            StartCoroutine(PlayerRecovery());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inHub = false;
        Debug.Log("Exit hub!");
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
