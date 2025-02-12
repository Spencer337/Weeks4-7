using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CarSpawn : MonoBehaviour
{
    public GameObject carPrefab;
    public int carAmount = 5;
    public List<GameObject> cars;
    void Start()
    {
        cars = new List<GameObject>();
        for (int i = 0; i < carAmount; i++)
        {
            Vector2 startPos = transform.position;
            startPos.y = Random.Range(-3, 3);

            GameObject newCar = Instantiate(carPrefab);
            newCar.transform.position = startPos;

            Car c = newCar.GetComponent<Car>();
            c.spawner = this;

            cars.Add(newCar);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //for(int i = 0; i < carAmount; i++)
        //{
        //    if(cars.transform.position)
        //}
    }
}
