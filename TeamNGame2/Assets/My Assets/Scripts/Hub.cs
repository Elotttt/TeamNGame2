using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub : MonoBehaviour
{
    public GameObject playerReference;
    public Player playerScriptReference;
    public bool inHub = false;

    public bool recoveringFromHit = false;
    public float recoveryTimeLeft;

    private void Start()
    {
        Debug.Log(VariableTransfer.points.ToString());
        recoveryTimeLeft = VariableTransfer.recoveryTimeLeft;

        if (recoveryTimeLeft <= 0)
        {
            recoveryTimeLeft = 5;
        }

        playerScriptReference.recoveringFromHit = VariableTransfer.playerRecovering;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2") && inHub)
        {
            SceneManager.LoadScene("IdleGame");
        }

        RecoveryTimer();
        VariableTransfer.recoveryTimeLeft = recoveryTimeLeft;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inHub = true;
            Debug.Log("Entered hub!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inHub = false;
            Debug.Log("Exit hub!");
        }
    }

    private void RecoveryTimer()
    {
        if (playerScriptReference.recoveringFromHit == true && inHub)
        {
            recoveryTimeLeft = recoveryTimeLeft - Time.deltaTime;
            if (recoveryTimeLeft <= 0)
            {
                playerScriptReference.recoveringFromHit = false;
                recoveryTimeLeft = 5;
                Debug.Log("Recovered at Hub!");
            }
        }
    }
}
