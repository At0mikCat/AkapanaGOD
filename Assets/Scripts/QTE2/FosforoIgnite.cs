using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class FosforoIgnite : MonoBehaviour
{
    public float speed = 5;
    bool ignited = false;
    public float counter = 5;
    public Vector3 pointB;
    private Vector3 originalPosition;

    public TextMeshProUGUI counterText;
    public GameObject panelLose;

    XboxController controls;

    [Range(0f, 1f)]
    public float ignitionProbability = 0.7f;

    public float moveDuration = 1.0f;
    private bool isMoving = false; 

    private void Awake()
    {
        controls = new XboxController();
        controls.Game.Enable();

        originalPosition = transform.position;
    }

    private void Update()
    {
        counter -= 1 * Time.deltaTime;
        counterText.text = "¡" + Mathf.FloorToInt(counter) + " segundos te quedan!";

        if (counter <= 1)
        {
            Time.timeScale = 0;
            panelLose.SetActive(true);
        }

        float h = Input.GetAxisRaw("Horizontal");

        if (h < 0 && !isMoving)
        {
            StartCoroutine(MoveToPosition(pointB));
        }

        if (ignited)
        {
            StartCoroutine(toGame2());
        }
    }

    IEnumerator toGame2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("3. Game2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FosforoZona"))
        {
            if (Random.Range(0f, 1f) < ignitionProbability)
            {
                ignited = true;
                changeColor();
                Debug.Log("Fosforo quemao we win"); 
            }
            else
            {
                Debug.Log("No se encendió, sigue intentando.");
            }

            StartCoroutine(returnToOrigin());
        }
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        isMoving = true; 
        Vector3 startPosition = transform.position;
        float journeyTime = 0;

        while (journeyTime < moveDuration)
        {
            journeyTime += Time.deltaTime;
            float t = journeyTime / moveDuration;

            transform.position = Vector3.Lerp(startPosition, targetPosition, t);
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false; 
    }

    IEnumerator returnToOrigin()
    {
        Vector3 startPosition = transform.position;
        float journeyTime = 0;

        while (journeyTime < moveDuration)
        {
            journeyTime += Time.deltaTime;
            float t = journeyTime / moveDuration;

            transform.position = Vector3.Lerp(startPosition, originalPosition, t);
            yield return null;
        }

        transform.position = originalPosition;
    }

    void changeColor()
    {
        GetComponent<Image>().color = Color.red;
    }
}