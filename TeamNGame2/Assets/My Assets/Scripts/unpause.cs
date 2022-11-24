using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unpause : MonoBehaviour
{
    public Button Butt;
    private void Start()
    {
        Butt.onClick.AddListener(Unpause);
    }
    private void Unpause()
    {
        Time.timeScale = 1;
    }
}
