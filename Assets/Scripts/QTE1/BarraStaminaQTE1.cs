using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraStaminaQTE1 : MonoBehaviour
{
    [SerializeField] private float descentSpeed = 0.315f;
    [SerializeField] private float rechargeAmount = 0.05f;

    [SerializeField] private Image staminaBar;
    public GameObject MenuLose;

    private void Awake()
    {
        MenuLose.SetActive(false);
    }

    void Update()
    {
        staminaBar.fillAmount -= descentSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            staminaBar.fillAmount += rechargeAmount;
        }

        if(staminaBar.fillAmount <= 0)
        {
            MenuLose.SetActive(true);
        }

        staminaBar.fillAmount = Mathf.Clamp(staminaBar.fillAmount, 0f, 1f);
    }
}
