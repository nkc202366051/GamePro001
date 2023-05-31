using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rusin : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = Random.Range(50, 501);
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.96f;


    }
}