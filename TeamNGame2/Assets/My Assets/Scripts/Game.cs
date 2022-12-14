using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float points;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //On click, adds point
        {
            points++;
            Debug.Log(points);
        }
    }
    public void ShowPoints()
    {
        Debug.Log(points);
    }
}
