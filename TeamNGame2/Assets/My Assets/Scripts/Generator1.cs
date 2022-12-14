using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator1 : MonoBehaviour
{
    public GameObject generator;
    public bool isActive;
    public int multiplier = 1;
    Game gameScript;
    WaitForSeconds waitForSeconds = new WaitForSeconds(1f);

    void Start()
    {
        gameScript = GetComponent<Game>();
    }

    void Update()
    {
        if (isActive)
        {
            Go();
        }
    }

    IEnumerator Go()
    {
        while (true)
        {
            gameScript.points = (gameScript.points + 1) * multiplier;
            Debug.Log(gameScript.points);
            yield return waitForSeconds;
        }
    }
}
