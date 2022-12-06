using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator1 : MonoBehaviour
{

    //GameObjects
    public GameObject camera;
    public GameObject generator;

    public Storage storageTwo;
    public Storage storageOne;

    //Upgrade Multiplier
    public int multiplier = 1;

    //Timer Variables
    float nextActionTime = 0.0f;
    float generateSpeed = 1f;


    Game gameScript;

    void Start()
    {
        storageOne = storageOne.GetComponent<Storage>();
        storageTwo = storageTwo.GetComponent<Storage>();
        gameScript = camera.GetComponent<Game>();
    }

    void Update()
    {
        if (generator.activeSelf)                                                   //Runs check if Generator is Active
        {                                                                           
            if (storageOne.quantity > 0)                                               //If there is any objects in storage, Runs main generator function
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime += generateSpeed;

                    storageOne.quantity--;                                             //Takes one away from storage once used
                    storageTwo.quantity++;

                    gameScript.points = gameScript.points + multiplier;             //Adds points in relation to Multiplier (Upgrades)
                    gameScript.ShowPoints();
                }
            }
            
        }
    }  
    
    
}
