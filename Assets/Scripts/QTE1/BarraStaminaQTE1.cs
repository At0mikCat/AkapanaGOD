using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BarraStaminaQTE1 : MonoBehaviour
{
    [SerializeField] private float descentSpeed = 0.315f;  
    [SerializeField] private float rechargeAmount = 0.05f; 
    [SerializeField] private Image staminaBar;

    public GameObject MenuLose;
    XboxController controls;
    Gamepad gamepad;

    private void Awake()
    {
        controls = new XboxController();
        controls.Game.Enable();
        controls.Game.IncreaseStamina.performed += ctx => IncreaseStamina();

        if (Gamepad.current != null)
        {
            gamepad = Gamepad.current;
        }
    }

    void Update()
    {
        staminaBar.fillAmount -= descentSpeed * Time.deltaTime;
        staminaBar.fillAmount = Mathf.Clamp(staminaBar.fillAmount, 0f, 1f);

        if(staminaBar.fillAmount <= 0.25f)
        {
            TriggerVibration();
        }

        if (staminaBar.fillAmount == 0)
        {
            MenuLose.SetActive(true);
            StopVibration();
        }
    }
    void TriggerVibration()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0.75f, 0.75f); 
            Invoke("StopVibration", 0.5f); 
        }
    }

    void StopVibration()
    {
        if (gamepad != null)
        {
            gamepad.SetMotorSpeeds(0f, 0f); 
        }
    }

    void IncreaseStamina()
    {
        staminaBar.fillAmount += rechargeAmount;
    }
}
