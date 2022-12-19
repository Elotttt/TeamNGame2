using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub : MonoBehaviour
{
    public GameObject playerReference;
    public Player playerScriptReference;
    public bool inHub = false;
    public float points;

    //public GameObject UIMail;
    public GameObject UIMail1;
    public GameObject UIMail2;
    public GameObject UIMail3;

    public bool hasPackage;
    public bool hasPackage1;
    public bool hasPackage2;
    public bool hasPackage3;

    public bool recoveringFromHit = false;
    public float recoveryTimeLeft;

    private void Start()
    {
        Debug.Log(VariableTransfer.points.ToString());
        points = VariableTransfer.points;
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
        VariableTransfer.points = points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inHub = true;
            Debug.Log("Entered hub!");
            //UIMail.SetActive(true);
            if (!hasPackage)
            {
                Time.timeScale = 0;
            }
            RandomMail();
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

    private void RandomMail()
    {
        if (!hasPackage)
        {
            int rdm = Random.Range(1, 4);
        
            if (rdm == 1)
            {
                UIMail1.SetActive(true);
                hasPackage1 = true;
            }
            else if (rdm == 2)
            {
                UIMail2.SetActive(true);
                hasPackage2 = true;
            }
            else
            {
                UIMail3.SetActive(true);
                hasPackage3 = true;
            }
            hasPackage = true;
        }
    }
}
