using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
   public void OnStartButton()
    {   
        Debug.Log("Start Button was pressed");
        SceneManager.LoadScene("lvl_1"); 
    }

    public void OnQuitButton()
    {
        Debug.Log("QUIT Button was pressed");
        Application.Quit();
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
