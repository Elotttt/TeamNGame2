using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TheoCol : MonoBehaviour
{
    public GameObject UITemp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UITemp.SetActive(true);
            Time.timeScale = 0;
        }
    }
}