using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu1 : MonoBehaviour
{
    public string playGameLevel;
    public string Main;

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }
    
    public void QuitGame()
    {
        Application.LoadLevel(Main);
    }
}
