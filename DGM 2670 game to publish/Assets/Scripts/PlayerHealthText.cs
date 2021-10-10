using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerHealthText : MonoBehaviour
{
    private Text Label;
    public UnityEvent UpdateHealthValue;
    public UnityEvent ResetHealth;

    void Start()
    {
        Label = GetComponent<Text>();
        ResetHealth.Invoke();
    }

    private void Update()
    {
        UpdateHealthValue.Invoke();
    }

    public void UpdateTextValue(FloatData obj)
    {
        Label.text = obj.value.ToString("Health: 0");
    }
}
