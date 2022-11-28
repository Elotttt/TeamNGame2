using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public float quantity;

    public GameObject camera;

    //Timer Variables
    float nextActionTime = 0.0f;
    float waitforSell = 10f;

    Game gameScript;

    void Start()
    {
        gameScript = camera.GetComponent<Game>();
    }

    void Update()
    {
        if (quantity> 0)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += waitforSell;

                SellItems();
            }
        }
        
    }

    void SellItems()
    {
        gameScript.points = gameScript.points + quantity;
        quantity = 0;

        gameScript.ShowPoints();
    }
}
