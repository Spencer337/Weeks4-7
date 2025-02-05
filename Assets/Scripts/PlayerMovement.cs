using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public GameObject food;
    public Image emoteBox;
    void Start()
    {
        emoteBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posPlayer = transform.position;
        Vector2 posFood = food.transform.position;

        if (posFood.x - posPlayer.x <= 1 && posFood.y - posPlayer.y <= 1)
        {
            emoteBox.enabled = true;
        }
        else
        {
            emoteBox.enabled = false;
        }

        posPlayer.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        posPlayer.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = posPlayer;
    }
}
