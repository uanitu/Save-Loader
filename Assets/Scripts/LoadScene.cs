using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("Level0");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

}
