using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Car : MonoBehaviour
{
    public float speed = 1;
    public CarSpawn spawner;
    void Start()
    {
        speed = Random.Range(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        pos.x += speed * Time.deltaTime;
        if (screenPos.x > Screen.width)
        {
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        }
        transform.position = pos;
    }
}
