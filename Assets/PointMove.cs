using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMove : MonoBehaviour
{
    private float time;
    private int vecX;
    private int vecY;

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0f)
        {
            vecX = Random.Range(-15, 15);
            vecY = Random.Range(-10, 10);
            transform.position = new Vector3(vecX, vecY, 0);
            time = 2.0f;
        }
    }
}