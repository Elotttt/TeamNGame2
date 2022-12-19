using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint2 : MonoBehaviour
{
    public Hub hubReference;
    public GameObject hasMediumUI;
    public AudioSource deliverySound;

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
                if (hubReference.hasPackage2)
                {
                    hubReference.hasPackage2 = false;
                    hubReference.points += 5;
                    hasMediumUI.SetActive(false);
                    deliverySound.Play();
                    Debug.Log("Delivered package 2");
                }
                hubReference.hasPackage = false;
            }
        }
    }
}
