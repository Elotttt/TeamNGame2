using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public float points;

    void Start()
    {
        points = VariableTransfer.points;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //On click, adds point
        {
            points++;
            Debug.Log(points);
            VariableTransfer.points = points;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void ShowPoints()
    {
        Debug.Log(points);
    }
}
