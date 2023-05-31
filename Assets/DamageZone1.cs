using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Player controller = other.GetComponent<Player>();

        if (controller != null)
        {
            controller.ChangeHealth(-10);
        }
    }
}