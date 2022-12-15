using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiMan : MonoBehaviour
{
    public void PlayGamee ()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    public void Rwload ()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
