using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailDelivery : MonoBehaviour
{
    public GameObject camera;
    Game gameScript;
    public GameObject generator;

    public float storageQuantity = 0f;
    float storageTopUp = 20f;

    float nextActionTime = 0.0f;
    float waitforSell = 10f;

    // Start is called before the first frame update
    void Start()
    {
        gameScript = camera.GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        if (generator.activeSelf)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += waitforSell;

                storageQuantity = storageQuantity + storageTopUp;
            }
        }
        
    }

    
}
