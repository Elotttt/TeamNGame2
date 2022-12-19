using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    public Hub hubReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (hubReference.hasPackage)
            {
                if (hubReference.hasPackage1)
                {
                    hubReference.hasPackage1 = false;
                    hubReference.points += 5;
                    Debug.Log("Delivered package 1");
                }
                hubReference.hasPackage = false;
            }
        }
    }
}
