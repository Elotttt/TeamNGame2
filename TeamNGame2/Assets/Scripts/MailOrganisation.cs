using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailOrganisation : MonoBehaviour
{
    public GameObject camera;
    Game gameScript;

    public Storage storageOne;
    public Storage storageTwo;
    public Storage storageThree;
    public Storage storageFour;
    public MailDelivery storageHub;

    float nextActionTime = 0.0f;
    float sendtoGenerator = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        gameScript = camera.GetComponent<Game>();
        
        storageOne = storageOne.GetComponent<Storage>();
        storageTwo = storageTwo.GetComponent<Storage>();
        storageThree = storageThree.GetComponent<Storage>();
        storageFour = storageFour.GetComponent<Storage>();

        storageHub = storageHub.GetComponent<MailDelivery>();
    }

    // Update is called once per frame
    void Update()
    {
        if (storageHub.storageQuantity > 0)
        {
            if (Time.time > sendtoGenerator)
            {
                nextActionTime += sendtoGenerator;

                if (storageOne.quantity > storageTwo.quantity)
                {
                    if (storageTwo.quantity > storageThree.quantity)
                    {
                        if (storageThree.quantity > storageFour.quantity)
                        {
                            Organise(storageFour);
                        }
                        else
                        {
                            Organise(storageThree);
                        }
                    }
                    else
                    {
                        Organise(storageTwo);
                    }
                    
                }
                else
                {
                    Organise(storageOne);
                }


            }
        }
    }

    void Organise(Storage storage)
    {
        storage.quantity++;
        storageHub.storageQuantity--;

    }      
}
