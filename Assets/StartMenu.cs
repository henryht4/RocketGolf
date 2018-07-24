using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    private int sceneIndex;


    public void Start_click()
    {
        //int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(2);

    }

    public void HowTo_click()
    {
        //int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(1);

    }

    public void Back_Click()
    {
        SceneManager.LoadScene(0);
    }
}
