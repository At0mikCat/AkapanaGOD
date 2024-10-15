using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuAnimations : MonoBehaviour
{
    public CanvasGroup[] images; 
    public float fadeDuration = 1.0f; 
    public float displayDuration = 2.0f; 

    XboxController controls;

    private void Awake()
    {
        controls = new XboxController();
        controls.Game.Enable();
        controls.Game.ExitCredits.performed += ctx => ExitCredits();
    }

    void Start()
    {
        StartCoroutine(PlayCredits());
    }

    IEnumerator PlayCredits()
    {
        for (int i = 0; i < images.Length; i++)
        {
            yield return StartCoroutine(FadeIn(images[i])); 
            yield return new WaitForSeconds(displayDuration); 
            yield return StartCoroutine(FadeOut(images[i])); 
        }
    }

    IEnumerator FadeIn(CanvasGroup canvasGroup)
    {
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, timer / fadeDuration); 
            yield return null;
        }
        canvasGroup.alpha = 1f;
    }

    IEnumerator FadeOut(CanvasGroup canvasGroup)
    {
        float timer = 0f;
        while (timer <= fadeDuration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration); 
            yield return null;
        }
        canvasGroup.alpha = 0f;
    }

    void ExitCredits()
    {
        SceneManager.LoadScene("0. MainMenu");
    }
}
