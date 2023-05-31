using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone4 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        hasyabutu controller = other.GetComponent<hasyabutu>();
        if (controller != null)
        {
            controller.ChangeHealth(-10);
        }
    }
}