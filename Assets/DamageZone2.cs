using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Boos controller = other.GetComponent<Boos>();
        if (controller != null)
        {
            controller.ChangeHealth(-10);
        }
    }
}