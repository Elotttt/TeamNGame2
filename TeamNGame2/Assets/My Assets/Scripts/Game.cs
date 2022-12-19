using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    public float points;

    public TMP_Text pointText;

    void Start()
    {
        points = VariableTransfer.points;
        pointText.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //On click, adds point
        {
            points++;
            pointText.text = points.ToString();
            VariableTransfer.points = points;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            VariableTransfer.points = points;
            SceneManager.LoadScene("Game");
        }
        VariableTransfer.points = points;
    }
    
}
