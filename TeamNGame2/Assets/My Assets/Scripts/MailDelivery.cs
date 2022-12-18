using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MailDelivery : MonoBehaviour
{
    //variables
    public GameObject camera;
    Game gameScript;

    public float storageQuantity = 0f;
    public float deliveryIncrease = 20f;


    //timer variables
    float nextActionTime = 0.0f;
    float waitforSell = 10f;

    // Start is called before the first frame update
    void Start()
    {
        gameScript = camera.GetComponent<Game>();
        storageQuantity = VariableTransfer.storageQuantity;
    }

    /// <summary>
    /// Main functionality of mail delivery, when time elapsed is more than the wait time, it runs the body
    /// </summary>
    void Update()
    {

        if (Time.time > nextActionTime)
        {
            //main body
            nextActionTime += waitforSell;                                  

            storageQuantity = storageQuantity + deliveryIncrease;           //how ever much is in the storage gets increased by the amount the delivery brings in
        }

        VariableTransfer.storageQuantity = storageQuantity;
        
    }

    
}
