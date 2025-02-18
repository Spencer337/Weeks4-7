using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
    public float t = 60;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the slider value is greater than zero, decrease the slider value by time
        if (slider.value > 0)
        {
            t -= Time.deltaTime;
            slider.value = t;
        }
    }
}
