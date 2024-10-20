using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicManager2 : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CinematicCounter());
    }

    IEnumerator CinematicCounter()
    {
        //pasan 15 segundos se va al QTE
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("4. QTE3");
    }
}
