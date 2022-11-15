using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator1 : MonoBehaviour
{
    public GameObject generator;
    public int multiplier = 1;
    public bool active;
    
    Game gameScript;

    WaitForSeconds waitForSeconds = new WaitForSeconds(1f);

    void Start()
    {
        gameScript = GetComponent<Game>();
    }

    void Update()
    {
        if (generator.activeSelf)
        {            
            Go();
        }
    }

    IEnumerator Go()
    {
        while (true)
        {
            
            gameScript.points = (gameScript.points + 1) * multiplier;
            gameScript.ShowPoints();
            
            yield return waitForSeconds;
        }
    }
}
