using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.1f);
    }
}