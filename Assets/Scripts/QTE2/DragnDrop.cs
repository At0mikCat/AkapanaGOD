using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{

    private bool isDragging = false;
    private Vector3 offset;

    [Range(0f, 1f)]
    public float igniteProbability = 0.5f; 

    bool ignited = false;

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            newPosition.z = 0;
            transform.position = newPosition;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FosforoZona") && !ignited)
        {
            TryIgnite();
        }

        if (collision.gameObject.CompareTag("ConopaZona") && ignited)
        {
            Debug.Log("Prendiste la wea");
        }
    }

    private void TryIgnite()
    {
        float randomValue = Random.Range(0f, 1f);
        if (randomValue <= igniteProbability)
        {
            ChangeColor(Color.blue); 
            Debug.Log("¡El fósforo se encendió!");
            ignited = true;
        }
        else
        {
            Debug.Log("El fósforo no se encendió.");
        }
    }

    private void ChangeColor(Color newColor)
    {
        GetComponent<Renderer>().material.color = newColor;
    }
}
