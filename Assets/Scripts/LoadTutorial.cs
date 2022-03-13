
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/

 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class LoadTutorial : MonoBehaviour
{

    public void LoadScene()
    {
        SceneManager.LoadScene("Level0");
    }
}