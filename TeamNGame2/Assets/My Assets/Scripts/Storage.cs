using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    //How much is in this storage
    public float quantity;

    //Sets which generator we're checking is active (first of next batch)
    public GameObject generator;

    //allows to call from generator script
    Generator1 generatorScript;

    void Start()
    {
        generatorScript = generator.GetComponent<Generator1>(); //calls the generator script from the chosen generator
        quantity = VariableTransfer.quantity;
    }
    void Update()
    {
        //if (generatorScript.isActive == false)
        //{
        //    //For sending packages to active part when setup...
        //}
        VariableTransfer.quantity = quantity;
    }
}
