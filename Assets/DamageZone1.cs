using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Cara controller = other.GetComponent<Cara>();

        if (controller != null)
        {
            controller.ChangeHealth(-10);
        }
    }
}