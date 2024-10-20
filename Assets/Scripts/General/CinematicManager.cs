using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicManager : MonoBehaviour
{
    public GameObject qte;
    public GameObject panel;
    public GameObject textTest;
    private void Awake()
    {
        qte.SetActive(false);
        StartCoroutine(CinematicCounter());
    }

    IEnumerator CinematicCounter()
    {
        //pasan 5 segundos se activa el QTE
        yield return new WaitForSeconds(6);
        qte.SetActive(true);

        //cuando pasan 5 segundos se desactiva el QTE
        yield return new WaitForSeconds(7);
        qte.SetActive(false);

        //cuando pasan x segundos se termina la parte 1 y se va al qte2
        yield return new WaitForSeconds(10);
        panel.SetActive(true);
        textTest.SetActive(true);
        SceneManager.LoadScene("2. QTE2");
    }
}
