using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelSelect : MonoBehaviour
{

    public void LoadScene()
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