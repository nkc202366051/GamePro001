using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy controller = other.GetComponent<Enemy>();
        Boos controoller = other.GetComponent<Boos>();
        if (controller != null)
        {
            controller.ChangeHealth(-10);
        }
    }
}