using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailDelivery : MonoBehaviour
{
    public GameObject camera;
    Game gameScript;


    float nextActionTime = 0.0f;
    float waitforSell = 120f;

    // Start is called before the first frame update
    void Start()
    {
        gameScript = camera.GetComponent<Game>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            
        }
    }
}
