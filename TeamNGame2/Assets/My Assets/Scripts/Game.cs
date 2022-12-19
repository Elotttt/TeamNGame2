using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    public float points;

    [SerializeField]
    private TMP_Text pointText;

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
            VariableTransfer.points = points;
            pointText.text = points.ToString();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            SceneManager.LoadScene("Game");
        }

       
    }
    
}
