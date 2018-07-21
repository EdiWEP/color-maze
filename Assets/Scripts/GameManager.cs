using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static int score = 0;

    public static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
    }

    public static void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContinueGame()
    {
        score = PlayerPrefs.GetInt("SavedScore");
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedLevel"));
    }

    public void RestartLevelFromMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void ExitToMenu()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        PlayerPrefs.SetInt("SavedLevel", SceneManager.GetActiveScene().buildIndex);
        score -= GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().score;
        PlayerPrefs.SetInt("SavedScore", score);
        score = 0;
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        score = 0;
        PlayerPrefs.SetInt("SavedLevel", 0);
        PlayerPrefs.SetInt("SavedScore", 0);
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }

}
