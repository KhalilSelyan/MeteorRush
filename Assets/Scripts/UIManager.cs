using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        scoreScript.scoreValue = 0;
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("howtoplay");
    }

    public void Menu()
    {
        scoreScript.scoreValue = 0;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Failed attempt at giving player choice of spaceship.

    //public void ChooseShip1()
    //{
    //    GameObject bir = GameObject.FindWithTag("MainCamera");
    //    playerSpawn iki = bir.GetComponent<playerSpawn>();
    //    iki.selectedShip = 0;
    //}

    //public void ChooseShip2()
    //{
    //    GameObject bir = GameObject.FindWithTag("MainCamera");
    //    playerSpawn iki = bir.GetComponent<playerSpawn>();
    //    iki.selectedShip = 1;
    //}

    
}
