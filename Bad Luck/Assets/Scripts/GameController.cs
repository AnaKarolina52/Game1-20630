using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

   public int totalScore;
   public Text scoreText;

   public GameObject gameOver;

   public GameObject WinnerPanel;

   public static GameController instance;

    // Start is called before the first frame update
   public void Start()
    {
        instance = this;
        WinnerPanel.SetActive(false);  
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
        Debug.Log("Score updated");
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }


    public void RestartGame()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    
    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void GameCompleted()
    {
        WinnerPanel.SetActive(true);
    }

}
