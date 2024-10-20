using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    public GameObject arrow;  // La flecha que se moverá junto al botón
    public Vector3 offset;    // Offset para ajustar la posición de la flecha respecto al botón

    private void Update()
    {
        // Verifica si hay un objeto actualmente seleccionado en el EventSystem
        GameObject selectedObject = EventSystem.current.currentSelectedGameObject;

        if (selectedObject != null && selectedObject.GetComponent<Button>() != null)
        {
            // Activa la flecha si no lo está
            if (!arrow.activeInHierarchy)
                arrow.SetActive(true);

            // Mueve la flecha al lado del botón seleccionado
            arrow.transform.position = selectedObject.transform.position + offset;
        }
        else
        {
            // Desactiva la flecha si no hay botón seleccionado
            arrow.SetActive(false);
        }
    }
}
