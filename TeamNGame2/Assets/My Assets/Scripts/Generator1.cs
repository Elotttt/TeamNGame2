using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Generator1 : MonoBehaviour
{
    //Text variables
    public TMP_Text pointText;

    public bool isActive;

    //GameObjects
    public GameObject camera;
    public GameObject generator;
   
    //Script variables
    public MailDelivery storageOne;
    public Storage storageTwo;
    Game gameScript;

    //Upgrade Multiplier
    public float multiplier = 1;                  //this is the variable for shop upgrades (plus by multiplier after generate speed)

    //Timer Variables
    float nextActionTime = 0.0f;
    public float generateSpeed = 1f;


    

    /// <summary>
    /// Initialises all variables with data from other scripts
    /// </summary>
    void Start()
    {       
        storageOne = storageOne.GetComponent<MailDelivery>();
        storageTwo = storageTwo.GetComponent<Storage>();
        gameScript = camera.GetComponent<Game>();
    }


    /// <summary>
    /// runs main point generator function
    /// </summary>
    void Update()
    {
        MainGenerator();
    }  
    

    /// <summary>
    /// This embodies the generator functionality
    /// if the generator is active in the game engine,
    /// and the time 
    /// </summary>
    void MainGenerator()
    {
        if (generator.activeSelf)                                                   //Runs check if Generator is Active and If there is any objects in storage, Runs main generator function
        {

            if (Time.time > nextActionTime)                                                         //
            {
                nextActionTime += generateSpeed;

                storageOne.storageQuantity--;                                             //Takes one away from storage once used
                storageTwo.quantity++;

                gameScript.points = gameScript.points + multiplier;                      //Adds points in relation to Multiplier (Upgrades)

                pointText.text = gameScript.points.ToString();                                              //displays points quantity to the ui                                      
            }



        }
    }
    
}
