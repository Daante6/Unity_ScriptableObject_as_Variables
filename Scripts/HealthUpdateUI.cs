using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpdateUI : MonoBehaviour
{
    public Slider healthSlider;
    public GlobalFloat healthValue;
    // Start is called before the first frame update
    void Start()
    {
        healthValue.OnValueChange.AddListener(() =>
        {
            healthSlider.value = Mathf.Lerp(0f,1f,healthValue.Value/100);
        });
    }
}
