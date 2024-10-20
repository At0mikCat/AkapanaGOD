using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    XboxController controls;
    private void Awake()
    {
        controls = new XboxController();
        controls.Game.Enable();
        controls.Game.ExitCredits.performed += ctx => ExitCredits();
    }

    void ExitCredits()
    {
        SceneManager.LoadScene("0. MainMenu");
    }
}
