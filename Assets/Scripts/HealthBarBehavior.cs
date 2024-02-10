using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    public Slider Slider;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        Slider.value = currentValue / maxValue;
        
    }
}
