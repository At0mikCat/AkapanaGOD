using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FosforoIgnite : MonoBehaviour
{
    public float speed = 5;
    bool ignited = false;

    XboxController controls;

    private void Awake()
    {
        controls = new XboxController();
        controls.Game.Enable();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        h = Mathf.Abs(h) * -1;

        transform.Translate(h * speed * Time.deltaTime, 0, 0);

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
            ignited = true;
            Debug.Log("Fosforo quemao we win");
        }
    }
}
