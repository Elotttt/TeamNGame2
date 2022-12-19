using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleUIButtons : MonoBehaviour
{
    public GameObject idleUI;
    public GameObject shopUI;

    public GameObject sorterOne;
    public GameObject sorterTwo;
    public GameObject sorterThree;
    public GameObject sorterFour;

    public GameObject shipperOne;
    public GameObject shipperTwo;

    Game gameScript;
    public GameObject camera;
    void Start()
    {
        gameScript = camera.GetComponent<Game>();
    }

    public void IdleStoreButton()
    {
        idleUI.SetActive(false);
        shopUI.SetActive(true);
    }
    public void ShopExit()
    {
        idleUI.SetActive(true);
        shopUI.SetActive(false);
    }
    public void SorterOneBuy()
    {
        if (gameScript.points >= 50)
        {
            sorterOne.SetActive(true);
            gameScript.points -= 50;
        }

    }
    public void SorterTwoBuy()
    {
        if (gameScript.points >= 100)
        {
            sorterTwo.SetActive(true);
            gameScript.points -= 100;
        }

    }
    public void SorterThreeBuy()
    {
        if (gameScript.points >= 200)
        {
            sorterThree.SetActive(true);
            gameScript.points -= 200;
        }

    }
    public void SorterFourBuy()
    {
        if (gameScript.points >= 400)
        {
            sorterFour.SetActive(true);
            gameScript.points -= 400;
        }

    }
    public void ShipperOneBuy()
    {
        if (gameScript.points >= 300)
        {
            shipperOne.SetActive(true);
            gameScript.points -= 300;
        }

    }
    public void ShipperTwoBuy()
    {
        if (gameScript.points >= 500)
        {
            shipperTwo.SetActive(true);
            gameScript.points -= 500;
        }

    }

}
