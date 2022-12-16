using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Generator1 : MonoBehaviour
{
    //Text variables
    [SerializeField]
    private TMP_Text pointText;

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
        pointText = GetComponent<TMP_Text>();
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
        if (generator.activeSelf && storageOne.storageQuantity > 0)                                                   //Runs check if Generator is Active and If there is any objects in storage, Runs main generator function
        {

            if (Time.time > nextActionTime)                                                         //
            {
                nextActionTime += generateSpeed;

                storageOne.storageQuantity--;                                             //Takes one away from storage once used
                storageTwo.quantity++;

                pointText.text = gameScript.points.ToString();                                              //displays points quantity to the ui                       

                gameScript.points = gameScript.points + multiplier;                      //Adds points in relation to Multiplier (Upgrades)
                gameScript.ShowPoints();    //debug to see points in console
            }



        }
    }
    
}
