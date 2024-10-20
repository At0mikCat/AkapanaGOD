using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicManager3 : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CinematicCounter());
    }

    IEnumerator CinematicCounter()
    {
        //pasan 10 segundos y termina la cinematica
        yield return new WaitForSeconds(10);
        //aca termina la cinematica
    }
}
