using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("1. Game1+QTE1");
    }
    public void Credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credits");
    }
    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
