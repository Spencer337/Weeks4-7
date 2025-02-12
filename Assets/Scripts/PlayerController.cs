using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 startPos;
    public float speed = 2;
    public CarSpawn spawner;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        startPos.x = 0f;
        startPos.y = -4.5f;
        Victory();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;
        //for(int i = 0; i < spawner.carAmount; i++)
        //{
        //    spawner.cars.
        //}
        if (transform.position.y >= 4)
        {
            Victory();
        }
    }

    void Victory()
    {
        transform.position = startPos;
    }
}
