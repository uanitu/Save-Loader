


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RestartLevel() //Restarts the level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        /* 
      if (Input.GetKeyDown("r"))
      {
             RestartLevel();
             Debug.Log("r");
      }
        */

        if (Input.GetKeyDown(KeyCode.R))
        {
            //Application.LoadLevel("Level1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
