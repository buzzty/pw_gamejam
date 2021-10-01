using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject mainMenu;
    public GameObject highScoreMenu;
    
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void ExitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }

    public void OpenSettings()
    {
        mainMenu.SetActive(false);
        settingMenu.SetActive(true);
    }
    
    public void CloseSettings()
    {
        mainMenu.SetActive(true);
        settingMenu.SetActive(false);
    }

    public void OpenHighScore()
    {
        highScoreMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    
    public void CloseHighScore()
    {
        highScoreMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
