using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRecoveryTimer : MonoBehaviour
{
    public bool recovering;
    public float recoveryTimeLeft;
    // Start is called before the first frame update
    void Start()
    {
        recoveryTimeLeft = VariableTransfer.recoveryTimeLeft;
        recovering = VariableTransfer.playerRecovering;
    }

    // Update is called once per frame
    void Update()
    {
        RecoveryTimer();
        VariableTransfer.recoveryTimeLeft = recoveryTimeLeft;
        VariableTransfer.playerRecovering = recovering;
    }

    private void RecoveryTimer()
    {
        if (recovering)
        {
            recoveryTimeLeft = recoveryTimeLeft - Time.deltaTime;
            if (recoveryTimeLeft <= 0)
            {
                recovering = false;
                //Debug.Log("Recovered at Hub!");
            }
        }
    }
}