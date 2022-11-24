using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator1 : MonoBehaviour
{

    //GameObjects
    public GameObject camera;
    public GameObject generator;
    public Storage storage;

    //Upgrade Multiplier
    public int multiplier = 1;

    //Timer Variables
    private float nextActionTime = 0.0f;
    public float period = 1f;

    Game gameScript;
    

    WaitForSeconds waitForSeconds = new WaitForSeconds(1f);

    void Start()
    {
        storage = storage.GetComponent<Storage>();
        gameScript = camera.GetComponent<Game>();
    }

    void Update()
    {
        if (generator.activeSelf)                                                   //Runs check if Generator is Active
        {                                                                           
            if (storage.quantity > 0)                                               //If there is any objects in storage, Runs main generator function
            {

                if (Time.time > nextActionTime)
                {
                    nextActionTime += period;                                        

                    storage.quantity--;                                             //Takes one away from storage once used

                    gameScript.points = gameScript.points + multiplier;             //Adds points in relation to Multiplier (Upgrades)
                    gameScript.ShowPoints();
                }
            }
            
        }
    }  
}
