using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public DotManager spawner;
    public SpriteRenderer sr;
    public float r;
    public float g;
    public float b;
    // public Color col;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // When one of the colour buttons is pressed, set the dot prefab’s colour to that buttons colour
    public void setWhite()
    {
        sr.color = new Color32(255, 255, 255, 255);
    }

    public void setLightGrey()
    {
        sr.color = new Color32(176, 176, 176, 255);
    }

    public void setGrey()
    {
        sr.color = new Color32(125, 125, 125, 255);
    }

    public void setDarkGrey()
    {
        sr.color = new Color32(70, 70, 70, 255);
    }

    public void setBlack()
    {
        sr.color = new Color32(0,0,0,255);
    }

    public void setRed()
    {
        sr.color = new Color32(255, 0, 0, 255);
    }

    public void setOrange()
    {
        sr.color = new Color32(255, 111, 8, 255);
    }

    public void setYellow()
    {
        sr.color = new Color32(255, 220, 8, 255);
    }

    public void setLightGreen()
    {
        sr.color = new Color32(31, 255, 8, 255);
    }

    public void setDarkGreen()
    {
        sr.color = new Color32(5, 154, 14, 255);
    }

    public void setLightBlue()
    {
        sr.color = new Color32(8, 147, 255, 255);
    }

    public void setDarkBlue()
    {
        sr.color = new Color32(8, 42, 255, 255);
    }

    public void setViolet()
    {
        sr.color = new Color32(67, 8, 255, 255);
    }

    public void setPurple()
    {
        sr.color = new Color32(109, 8, 255, 255);
    }

    public void setMagenta()
    {
        sr.color = new Color32(197, 8, 255, 255);
    }

    public void setPink()
    {
        sr.color = new Color32(219, 104, 205, 255);
    }

    // When the Random button is pressed, set the dot prefab’s colour to a random colour
    public void setRandom()
    {
        r = Random.Range(0, 255);
        g = Random.Range(0, 255);
        b = Random.Range(0, 255);
        sr.color = new Color32((byte)r, (byte)g, (byte)b, 255);
    }
}
