using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Generator1 : MonoBehaviour
{

    [SerializeField]
    private TMP_Text pointText;

    //GameObjects
    public GameObject camera;
    public GameObject generator;
   

    public MailDelivery storageOne;
    public Storage storageTwo;
    

    //Upgrade Multiplier
    public int multiplier = 1;

    //Timer Variables
    float nextActionTime = 0.0f;
    public float generateSpeed = 1f;


    Game gameScript;

    void Start()
    {
        pointText = GetComponent<TMP_Text>();
        storageOne = storageOne.GetComponent<MailDelivery>();
        storageTwo = storageTwo.GetComponent<Storage>();
        gameScript = camera.GetComponent<Game>();
    }

    void Update()
    {
        if (generator.activeSelf)                                                   //Runs check if Generator is Active
        {                                                                           
            if (storageOne.storageQuantity > 0)                                               //If there is any objects in storage, Runs main generator function
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime += generateSpeed;

                    storageOne.storageQuantity--;                                             //Takes one away from storage once used
                    storageTwo.quantity++;

                    pointText.text = "hi";

                    gameScript.points = gameScript.points + multiplier;             //Adds points in relation to Multiplier (Upgrades)
                    gameScript.ShowPoints();
                }
            }
            
        }
    }  
    
    
}
