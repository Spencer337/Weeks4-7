using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public SpriteRenderer colour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColour();
        }
    }

    public void ChangeColour()
    {
        colour.color = Random.ColorHSV();
    }
}
