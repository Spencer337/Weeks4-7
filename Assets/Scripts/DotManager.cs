using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class DotManager : MonoBehaviour
{
    public float xSize = 1;
    public float ySize = 1;
    public int dotsAmount = 0;
    public GameObject dotPrefab;
    public Timer timer;
    public List<GameObject> dots;


    // Start is called before the first frame update
    void Start()
    {
        dots = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // If mouse is clicked and timer is greater than zero
        if (Input.GetMouseButtonDown(0) && timer.t > 0)
        {
            // Instantiate a new dot prefab
            // Set its position to the mouse position
            // Set it’s with to the Xsize variable and it’s height to the Ysize variable
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newDot = Instantiate(dotPrefab);
            newDot.transform.position = mousePos;
            newDot.transform.localScale = new Vector3(xSize, ySize, 1);

            // Add the dot to the list
            // Increase dot amount by 1
            Dot d = newDot.GetComponent<Dot>();
            dots.Add(newDot);  
            dotsAmount++;
        }
    }

    // Set xSize to newX
    public void updateXSize (float newX)
    {
        xSize = newX;
    }

    // Set ySize to newY
    public void updateYSize(float newY)
    {
        ySize = newY;
    }

    // When the eraser button is pressed
    public void resetCanvas()
    {
        // Loop through the list of dots, destroying them all
        for (int i = 0; i < dotsAmount; i++)
        {
            Destroy(dots[i].gameObject);
        }

        // Clear the list
        // Set dots amount to 0
        dots.Clear();
        dotsAmount = 0;
    }
}
