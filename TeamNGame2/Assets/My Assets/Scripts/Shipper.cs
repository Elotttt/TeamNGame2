using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shipper : MonoBehaviour
{
    //Text variables
    public TMP_Text pointText;

    //Script variables
    //public MailDelivery mailDelivery;
    public Storage storageOne;
    public Storage storageTwo;
    public Game gameScript;

    //Upgrade Multiplier
    public float multiplier = 1;                  //this is the variable for shop upgrades (plus by multiplier after generate speed)

    //Timer Variables
    public float nextActionTime = 0.0f;
    public float generateSpeed = 1f;




    /// <summary>
    /// Initialises all variables with data from other scripts
    /// </summary>
    void Start()
    {

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
        if (storageOne.quantity > 0)                                                   //Runs check if Generator is Active and If there is any objects in storage, Runs main generator function
        {

            if (Time.time > nextActionTime)                                                         //
            {
                nextActionTime += generateSpeed;

                storageOne.quantity--;                                             //Takes one away from storage once used
                storageTwo.quantity++;

                pointText.text = gameScript.points.ToString();                                              //displays points quantity to the ui                       

                gameScript.points = gameScript.points + multiplier;                      //Adds points in relation to Multiplier (Upgrades)
                gameScript.ShowPoints();    //debug to see points in console
            }
        }
    }

}