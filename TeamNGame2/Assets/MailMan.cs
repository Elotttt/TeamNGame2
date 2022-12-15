using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class MailMan : MonoBehaviour
{
    public bool MailCounter;
    public GameObject UIMail;

    public void GainMail()
    {
        MailCounter = true;
        UIMail.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MailCounter = false;
            UIMail.SetActive(false);
        }
    }
}
