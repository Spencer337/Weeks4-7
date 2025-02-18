using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPreview : MonoBehaviour
{
    public RawImage ri;
    public Dot d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When one of the colour buttons is pressed, set the preview image colour to the same colour as the dot
    public void setWhite()
    {
        ri.color = new Color32(255, 255, 255, 255);
    }

    public void setLightGrey()
    {
        ri.color = new Color32(176, 176, 176, 255);
    }

    public void setGrey()
    {
        ri.color = new Color32(125, 125, 125, 255);
    }

    public void setDarkGrey()
    {
        ri.color = new Color32(70, 70, 70, 255);
    }

    public void setBlack()
    {
        ri.color = new Color32(0, 0, 0, 255);
    }

    public void setRed()
    {
        ri.color = new Color32(255, 0, 0, 255);
    }

    public void setOrange()
    {
        ri.color = new Color32(255, 111, 8, 255);
    }

    public void setYellow()
    {
        ri.color = new Color32(255, 220, 8, 255);
    }

    public void setLightGreen()
    {
        ri.color = new Color32(31, 255, 8, 255);
    }

    public void setDarkGreen()
    {
        ri.color = new Color32(5, 154, 14, 255);
    }

    public void setLightBlue()
    {
        ri.color = new Color32(8, 147, 255, 255);
    }

    public void setDarkBlue()
    {
        ri.color = new Color32(8, 42, 255, 255);
    }

    public void setViolet()
    {
        ri.color = new Color32(67, 8, 255, 255);
    }

    public void setPurple()
    {
        ri.color = new Color32(109, 8, 255, 255);
    }

    public void setMagenta()
    {
        ri.color = new Color32(197, 8, 255, 255);
    }

    public void setPink()
    {
        ri.color = new Color32(219, 104, 205, 255);
    }

    // When the Random button is pressed, set the preview image colour to the same colour as the dot
    public void setRandom()
    {
        ri.color = new Color32((byte)d.r, (byte)d.g, (byte)d.b, 255);
    }
}
