using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraEquilibrioQTE1 : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;

    public GameObject InputD; //ParaELQUICKTIMEEVENTAMEVOYAMORIRESTOYXATAX2
    public GameObject InputA; //ParaELQUICKTIMEEVENTAMEVOYAMORIRESTOYXATAX2

    public GameObject MenuLose;

    bool reverse = false;
    bool waitingForInput = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        InputD.SetActive(false);
        InputA.SetActive(false);
        MenuLose.SetActive(false);
    }

    void Update()
    {
        if (!waitingForInput)
        {
            if (!reverse)
            {
                rb.velocity = new Vector2(speed, 0); 
            }
            else
            {
                rb.velocity = new Vector2(-speed, 0); 
            }
        }

        if (waitingForInput && !reverse && Input.GetKeyDown(KeyCode.D)) //aqui irian los gatillos del joycon
        {
            reverse = true; 
            waitingForInput = false;
            InputD.SetActive(false); 
        }

        if (waitingForInput && reverse && Input.GetKeyDown(KeyCode.A)) //aqui irian los gatillos del joycon
        {
            reverse = false; 
            waitingForInput = false;
            InputA.SetActive(false); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowTriggerRight") && !reverse)
        {
            waitingForInput = true;
            InputD.SetActive(true); 
        }

        if (other.gameObject.CompareTag("YellowTriggerLeft") && reverse)
        {
            waitingForInput = true;
            InputA.SetActive(true); 
        }

        if (other.gameObject.CompareTag("RedTrigger"))
        {
            InputD.SetActive(false);
            InputA.SetActive(false);
            Time.timeScale = 0;
            MenuLose.SetActive(true);
        }
    }
}
