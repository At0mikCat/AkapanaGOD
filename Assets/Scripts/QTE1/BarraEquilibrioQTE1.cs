using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarraEquilibrioQTE1 : MonoBehaviour
{
        public float speed = 5;
        private Rigidbody rb;

        public GameObject InputD;
        public GameObject InputA;

        public GameObject MenuLose;

        bool reverse = false;
        bool waitingForInput = false;

        XboxController controls;
        Gamepad gamepad;

    void Awake()
    {
         rb = GetComponent<Rigidbody>();
         InputD.SetActive(false);
         InputA.SetActive(false);
         MenuLose.SetActive(false);

         controls = new XboxController();
         controls.Game.Enable();
        controls.Game.ToLeft.performed += ctx => ToLeft();
        controls.Game.ToRight.performed += ctx => ToRight();

        if (Gamepad.current != null)
        {
            gamepad = Gamepad.current;
        }
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
        }

    void ToLeft()
    {
        if (waitingForInput && !reverse)
        {
            reverse = true;
            waitingForInput = false;
            InputD.SetActive(false);
        }
    }

    void ToRight()
    {
        if (waitingForInput && reverse) 
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

            if(other.gameObject.CompareTag("Advice"))
        {
            TriggerVibration();
        }

            if (other.gameObject.CompareTag("RedTrigger"))
            {
                InputD.SetActive(false);
                InputA.SetActive(false);
                Time.timeScale = 0;
                MenuLose.SetActive(true);
            StopVibration();
        }
        }

    void TriggerVibration()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0.75f, 0.75f); // Establece la vibración en los motores izquierdo y derecho
            Invoke("StopVibration", 0.5f); // Detiene la vibración después de 0.5 segundos
        }
    }

    // Método para detener la vibración
    void StopVibration()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0f, 0f); // Apaga la vibración
        }
    }
}

