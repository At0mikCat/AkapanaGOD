using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    public GameObject arrow;  // La flecha que se mover� junto al bot�n
    public Vector3 offset;    // Offset para ajustar la posici�n de la flecha respecto al bot�n

    private void Update()
    {
        // Verifica si hay un objeto actualmente seleccionado en el EventSystem
        GameObject selectedObject = EventSystem.current.currentSelectedGameObject;

        if (selectedObject != null && selectedObject.GetComponent<Button>() != null)
        {
            // Activa la flecha si no lo est�
            if (!arrow.activeInHierarchy)
                arrow.SetActive(true);

            // Mueve la flecha al lado del bot�n seleccionado
            arrow.transform.position = selectedObject.transform.position + offset;
        }
        else
        {
            // Desactiva la flecha si no hay bot�n seleccionado
            arrow.SetActive(false);
        }
    }
}
