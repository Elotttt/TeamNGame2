using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unpause : MonoBehaviour
{
    public Button Butt;
    public AudioSource notificationSound;
    private void Start()
    {
        Butt.onClick.AddListener(Unpause);
    }
    public void Unpause()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void PlayAudio()
    {
        notificationSound.Play();
    }
}
