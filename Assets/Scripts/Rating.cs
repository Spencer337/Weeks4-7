using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rating : MonoBehaviour
{
    public float quality = 0;
    public Slider visuals;
    public Timer timer; 
    // Start is called before the first frame update
    void Start()
    {
        // Set minimum to zero, and maximum to 100
        visuals.minValue = 0;
        visuals.maxValue = 100;
        // Set visuals value to the quality float
        visuals.value = quality;
    }

    // Update is called once per frame
    void Update()
    {
        // If mouse is clicked and timer is greater than zero,
        // Increase score by one
        if (Input.GetMouseButtonDown(0) && timer.t > 0)
        {
            scoreUp(1);
        }
    }

    // Increase the slider value by the score parameter
    public void scoreUp(int score)
    {
        quality += score;
        visuals.value = quality;
    }
}
