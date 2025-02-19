using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int score;
    public int health;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        health = 3;
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;
    }
}
